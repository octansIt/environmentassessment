using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using VimApi_65;
using EnvironmentAssessment.Collector;

namespace EnvironmentAssessment.Common.VimApi
{
    public class VimClient : IVimClient
    {
        internal const ushort DefaultPort = 443;

        private int _serviceTimeout = 100000;
        private ServiceContent _serviceContent;
        private VimVersion _version;
        private VimPortType _vimService;
        private string _serviceUrl;
        private const ushort DEFAULT_HTTPS_PORT = 443;
        private const string SESSION_COOKIE_NAME = "vmware_soap_session";

        public VimVersion Version
        {
            get
            {
                return this._version;
            }
        }

        object IVimClient.VimService
        {
            get
            {
                return (object)this._vimService;
            }
        }

        public ServiceContent ServiceContent
        {
            get
            {
                return this._serviceContent;
            }
        }

        public string ServiceUrl
        {
            get
            {
                return this._serviceUrl;
            }
            set
            {
                this._serviceUrl = value;
            }
        }

        public int ServiceTimeout
        {
            get
            {
                return this._serviceTimeout;
            }
            set
            {
                this._serviceTimeout = value;
            }
        }

        public string SessionSecret
        {
            get
            {
                Cookie sessionCookie = this.TryGetSessionCookie(new Uri(this.ServiceUrl));
                if (sessionCookie == null)
                    return (string)null;
                return sessionCookie.Value;
            }
            set
            {
                CookieContainer cookieContainer = this.GetCookieContainer();
                Cookie sessionCookie = this.TryGetSessionCookie(new Uri(this.ServiceUrl));
                if (value == null)
                {
                    if (sessionCookie == null)
                        return;
                    sessionCookie.Expired = true;
                }
                else
                {
                    string str = "\"" + value.Trim('"') + "\"";
                    if (sessionCookie != null)
                    {
                        sessionCookie.Value = str;
                        sessionCookie.Expired = false;
                    }
                    else
                        cookieContainer.Add(new Cookie("vmware_soap_session", str, "/", new Uri(this.ServiceUrl).Host));
                }
            }
        }

        public string UserAgent { get; set; }

        private static bool MatchProperyList(NameValueCollection filter, System.Type viewType, IDictionary<string, object> propList)
        {
            bool flag1 = true;
            foreach (string key1 in filter.Keys)
            {
                string key2 = VimClient.ValidatePropertyPath(viewType, key1);
                if (propList.ContainsKey(key2))
                {
                    string pattern = filter[key2];
                    if (propList[key2] is ManagedObjectReference[])
                    {
                        bool flag2 = false;
                        foreach (ManagedObjectReference managedObjectReference in (ManagedObjectReference[])propList[key2])
                        {
                            Match match = Regex.Match(managedObjectReference.Value, pattern, RegexOptions.IgnoreCase);
                            flag2 = flag2 || match.Success;
                        }
                        if (!flag2)
                        {
                            flag1 = false;
                            break;
                        }
                    }
                    else if (!Regex.Match(!(propList[key2] is ManagedObjectReference) ? (!(propList[key2] is string[]) ? propList[key2].ToString() : string.Join(",", propList[key2] as string[])) : ((ManagedObjectReference)propList[key2]).Value, pattern, RegexOptions.IgnoreCase).Success)
                    {
                        flag1 = false;
                        break;
                    }
                }
                else
                {
                    flag1 = false;
                    break;
                }
            }
            return flag1;
        }

        private static string[] ValidatePropertyPathList(System.Type viewType, string[] propertyList)
        {
            List<string> stringList = new List<string>();
            if (propertyList != null && propertyList.Length != 0)
            {
                foreach (string property in propertyList)
                {
                    string str = VimClient.ValidatePropertyPath(viewType, property);
                    stringList.Add(str);
                }
            }
            if (stringList.Count != 0)
                return stringList.ToArray();
            return (string[])null;
        }

        private static string ValidatePropertyPath(System.Type viewType, string inputProperty)
        {
            System.Type type = viewType;
            string[] strArray1 = inputProperty.Split('.');
            string[] strArray2 = new string[strArray1.Length];
            for (int index = 0; index < strArray1.Length; ++index)
            {
                PropertyInfo propertyInfo = (PropertyInfo)null;
                if (type != (System.Type)null)
                    ViReflectionCache.GetTypeProperties(type).TryGetValue(strArray1[index].ToLower(), out propertyInfo);
                if (propertyInfo != (PropertyInfo)null)
                {
                    type = propertyInfo.PropertyType;
                    strArray2[index] = VimClient.MakeCamelCase(propertyInfo.Name);
                }
                else
                {
                    strArray2[index] = VimClient.MakeCamelCase(strArray1[index]);
                    type = (System.Type)null;
                }
            }
            return string.Join(".", strArray2);
        }

        internal static string MakeCamelCase(string s)
        {
            string str = s;
            if (!string.IsNullOrEmpty(s))
            {
                StringBuilder stringBuilder = new StringBuilder(s);
                if (stringBuilder.Length > 0)
                    stringBuilder[0] = char.ToLower(stringBuilder[0]);
                str = stringBuilder.ToString();
            }
            return str;
        }

        internal static string MakePropertyCamelCase(string property)
        {
            string str = property;
            if (!string.IsNullOrEmpty(property))
            {
                string[] strArray1 = property.Split('.');
                string[] strArray2 = new string[strArray1.Length];
                for (int index = 0; index < strArray1.Length; ++index)
                    strArray2[index] = VimClient.MakeCamelCase(strArray1[index]);
                str = string.Join(".", strArray2);
            }
            return str;
        }

        internal static string[] MakePropertiesCamelCase(string[] properties)
        {
            string[] strArray = (string[])null;
            if (properties != null)
            {
                strArray = new string[properties.Length];
                for (int index = 0; index < properties.Length; ++index)
                    strArray[index] = VimClient.MakePropertyCamelCase(properties[index]);
            }
            return strArray;
        }

        public ServiceContent Connect()
        {
            if (string.IsNullOrEmpty(this._serviceUrl))
                throw new InvalidOperationException(Resources.InvalidServiceUrl);
            try
            {
                this._vimService = this.CreateClientChannel();
                ServiceContent content = new ServiceInstance((VimClient)this, new ManagedObjectReference()
                {
                    Type = "ServiceInstance",
                    Value = "ServiceInstance"
                }).RetrieveServiceContent();
                this._version = VersionUtils.GetVIServerVersion(content);
                this._serviceContent = content;
                return this._serviceContent;
            }
            catch (ProtocolException ex)
            {
                throw new VimProtocolException(ex.Message, (Exception)ex);
            }
            catch (EndpointNotFoundException ex)
            {
                throw new VimEndpointNotFoundException(ex.Message, (Exception)ex);
            }
            catch (SecurityNegotiationException ex)
            {
                throw new VimSecurityNegotiationException(ex.Message, (Exception)ex);
            }
            catch (CommunicationException ex)
            {
                throw new VimException(ex.Message, (Exception)ex);
            }
        }

        private CookieContainer GetCookieContainer()
        {
            IHttpCookieContainerManager property = ((IChannel)this._vimService).GetProperty<IHttpCookieContainerManager>();
            if (property == null)
                throw new InvalidOperationException("Client does not support cookies.");
            return property.CookieContainer;
        }

        private Cookie TryGetSessionCookie(Uri uri)
        {
            CookieContainer cookieContainer = this.GetCookieContainer();
            if (cookieContainer == null)
                return (Cookie)null;
            return cookieContainer.GetCookies(new Uri(this.ServiceUrl)).OfType<Cookie>().FirstOrDefault<Cookie>((Func<Cookie, bool>)(cookie => "vmware_soap_session".Equals(cookie.Name, StringComparison.OrdinalIgnoreCase)));
        }

        public ServiceContent Connect(string serviceUrl)
        {
            this.ServiceUrl = serviceUrl;
            return this.Connect();
        }

        public ServiceContent Connect(string server, CommunicationProtocol? protocol, ushort? port)
        {
            if (!protocol.HasValue)
                protocol = new CommunicationProtocol?(CommunicationProtocol.Https);
            if (string.IsNullOrEmpty(server))
                server = "127.0.0.1";
            if (!port.HasValue)
            {
                CommunicationProtocol? nullable = protocol;
                CommunicationProtocol communicationProtocol = CommunicationProtocol.Https;
                if ((nullable.GetValueOrDefault() == communicationProtocol ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    port = new ushort?((ushort)443);
            }
            this.ServiceUrl = protocol.ToString().ToLower() + "://" + server + (port.HasValue ? ":" + (object)port.Value : string.Empty) + "/sdk";
            return this.Connect();
        }

        internal UserSession Login(EnvironmentAssessment.Collector.ISession Session)
        {
            string error = "";
            string logintime = "";
            UserSession us = null;
            this.ServiceUrl = "https://" + Session.Server.Name.ToLower() + "/sdk";
            ServiceTimeout = COptions.VI_Login_Timeout;

            try
            {
                if (this._vimService == null || this._serviceContent == null) { this.Connect(); }
            }
            catch (VimException ex)
            {
                Common.Log.Write("[VimApi] Connecting to '" + this.ServiceUrl + "' failed: " + ex.Message);
                Session.Error = ex.Message;
                return null;
            }

            SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
            try
            {
                Common.Log.Write("[VimApi] Connecting to '" + this.ServiceUrl + "' using specified credentials [" + Session.Server.UserName + "]");
                us = sessionManager.Login(Session.Server.UserName, Session.Server.UserPassword, null);
                logintime = us.LoginTime.ToString();
            }
            catch (VimApi.VimException ex)
            {
                error = ex.Message;
            }
            if (logintime.Length > 0)
            {
                Common.Log.Write("[VimApi] Logged into '" + this.ServiceUrl + "' at " + us.LoginTime + " (" + this.Version.ToString().ToLower() + ").");
                return us;
            }
            else { Common.Log.Write("[VimApi] Login into '" + this.ServiceUrl + "' failed: " + error); Session.Error = error; return null; }

        }

        public UserSession Login(string username, string password)
        {
            if (this._vimService == null || this._serviceContent == null)
                this.Connect();
            return new SessionManager((VimClient)this, this.ServiceContent.SessionManager).Login(username, password, (string)null);
        }

        public UserSession Login(string serviceUrl, string username, string password)
        {
            this.Connect(serviceUrl);
            return new SessionManager((VimClient)this, this.ServiceContent.SessionManager).Login(username, password, (string)null);
        }
        internal UserSession LoginSSPI(EnvironmentAssessment.Collector.ISession Session)
        {
            string error = "";
            string logintime = "";
            UserSession us = null;
            this.ServiceUrl = "https://" + Session.Server.Name + "/sdk";
            ServiceTimeout = COptions.VI_Login_Timeout;

            try
            {
                if (this._vimService == null || this._serviceContent == null) { this.Connect(); }
            }
            catch (System.Net.WebException ex)
            {
                Common.Log.Write("[VimApi] Connecting to '" + this.ServiceUrl + "' failed: " + ex.Message);
                Session.Error = ex.Message;
                return null;
            }

            SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);

            if (sessionManager != null)
            {
                Boolean flag = true;

                // get server's fqdn for cross-domain authentication
                string FQDN = Session.Server.Name.Substring(Session.Server.Name.IndexOf('.'));
                Common.Sspi.Credentials.CClientCredential clientCred = new Common.Sspi.Credentials.CClientCredential(Sspi.CPackageNames.Negotiate);

                Common.Sspi.Contexts.CClientContext clientContext = null;

                string os = this.ServiceContent.About.OsType;
                if (os.Contains("win"))
                {
                    string serviceprincipal = "host/" + Session.Server.Name + "@" + FQDN;
                    clientContext = new Common.Sspi.Contexts.CClientContext(clientCred, serviceprincipal, Common.Sspi.Contexts.CContextAttrib.Zero);
                    Log.Write("[SSPI] Initialized client context for connection to Windows-based vCenter (" + os + ") using service principal: " + serviceprincipal);
                }
                else
                {
                    string serviceprincipal = "host/" + Session.Server.Name;
                    clientContext = new Common.Sspi.Contexts.CClientContext(clientCred, serviceprincipal, Sspi.Contexts.CContextAttrib.Zero);
                    Log.Write("[SSPI] Initialized client context for connection to Linux-based vCenter (" + os + ") using service principal: " + serviceprincipal);
                }

                byte[] clientToken = null;
                byte[] serverToken = null;
                string clientLocale = "en"; //using default locale, should work according to documentation
                bool retry = false;

                Common.Sspi.CSecurityStatus clientStatus;

                while (flag)
                {
                    try //sspi authentication
                    {
                        clientStatus = clientContext.Init(serverToken, out clientToken);
                        Common.Log.Write("[VimApi] Connecting to '" + this.ServiceUrl + "' using Windows Session Credentials [" + Environment.UserDomainName + @"\" + Environment.UserName + "] (SSPI Token)");
                        Common.Log.Write("[SSPI] Client token sent <base64Token>" + Convert.ToBase64String(clientToken) + "</base64Token><locale>" + clientLocale + "</locale>", Log.Verbosity.Debug);
                        us = sessionManager.LoginBySSPI(Convert.ToBase64String(clientToken), clientLocale);
                        flag = false;
                    }
                    catch (VimApi.VimException e)
                    {
                        if (e.MethodFault is SSPIChallenge)
                        {
                            Common.Log.Write("[VimApi] Responding to SSPI challenge from '" + this.ServiceUrl + "' (SSPI challenge response)");
                            serverToken = Convert.FromBase64String(((SSPIChallenge)e.MethodFault).Base64Token);
                            Log.Write("[SSPI] Server token returned <base64Token>" + ((SSPIChallenge)e.MethodFault).Base64Token + "</base64Token>", Log.Verbosity.Debug);
                        }
                        else if (e.MethodFault is InvalidLogin)
                        {
                            //Log.Write("Login with current credentials (SSPI) failed, please enter credentials: " + e.Message);
                            error = "Login with current credentials (SSPI) failed, please enter credentials: " + e.Message; flag = false;
                        }
                        else
                        {
                            try { logintime = us.LoginTime.ToString(); flag = false; }
                            catch (Exception ex) { error = ex.Message; flag = true; }
                        }
                    }
                    catch (Common.Sspi.CSSPIException e)
                    {
                        error = "Login with current credentials (SSPI) unsupported, please enter credentials: " + e.Message; flag = false;
                    }
                    catch (Exception e)
                    {
                        error = "Login with current credentials (SSPI) unsupported, please enter credentials: Server does not have SSPI authentication configured."; flag = false;
                    }
                }
                if (logintime.Length == 0)
                {
                    if (us != null)
                    {
                        if (us.LoginTime != null)
                        { logintime = us.LoginTime.ToString(); }
                    }
                }
            }

            if (logintime.Length > 0)
            {
                Common.Log.Write("[VimApi] Logged into '" + this.ServiceUrl + "' at " + us.LoginTime + " (" + this.Version.ToString().ToLower() + ").");
                return us;
            }
            else
            {
                Common.Log.Write("[VimApi] Login into '" + this.ServiceUrl + "' failed: " + error);
                Session.Error = error;
                return null;
            }
        }

        public void Logout()
        {
            if (this._serviceContent == null)
                throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
            new SessionManager((VimClient)this, this._serviceContent.SessionManager).Logout();
        }

        public UserSession ConnectToSession(string serviceUrl, string soapSessionId)
        {
            if (string.IsNullOrEmpty(soapSessionId))
                throw new InvalidOperationException(Resources.SessionIdNotInitialized);
            this.Connect(serviceUrl);
            this.SessionSecret = soapSessionId;
            SessionManager sessionManager = new SessionManager((VimClient)this, this.ServiceContent.SessionManager);
            sessionManager.UpdateViewData();
            return sessionManager.CurrentSession;
        }

        public EntityViewBase FindEntityView(System.Type viewType, ManagedObjectReference beginEntity, NameValueCollection filter, string[] properties)
        {
            if (viewType == (System.Type)null)
                throw new ArgumentNullException("viewType");
            if (this._vimService == null)
                throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
            if (this._serviceContent == null)
                throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
            if (!viewType.IsSubclassOf(typeof(EntityViewBase)))
                throw new InvalidOperationException(Resources.InvalidViewTypeParam);
            EntityViewBase entityViewBase = (EntityViewBase)null;
            ManagedObjectReference beginEntity1 = beginEntity ?? this._serviceContent.RootFolder;
            string[] strArray = (string[])null;
            if (filter != null && filter.Count > 0)
            {
                string[] propertyList = new string[filter.Count];
                filter.AllKeys.CopyTo((Array)propertyList, 0);
                strArray = VimClient.ValidatePropertyPathList(viewType, propertyList);
            }
            ObjectContent[] objectContentArray = new PropertyCollector((VimClient)this, this._serviceContent.PropertyCollector).RetrieveProperties(new PropertyFilterSpec[1]
            {
        EntityViewBase.GetSearchFilterSpec((VimClient) this, beginEntity1, new PropertySpec()
        {
          All = new bool?(false),
          Type = viewType.Name,
          PathSet = strArray
        })
            });
            ManagedObjectReference moRef = (ManagedObjectReference)null;
            if (objectContentArray != null)
            {
                foreach (ObjectContent objectContent in objectContentArray)
                {
                    if (beginEntity == null || !objectContent.Obj.Value.Equals(beginEntity.Value) || !objectContent.Obj.Type.Equals(beginEntity.Type))
                    {
                        if (filter != null && filter.Count > 0)
                        {
                            DynamicProperty[] propSet = objectContent.PropSet;
                            if (propSet != null)
                            {
                                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                                foreach (DynamicProperty dynamicProperty in propSet)
                                    dictionary.Add(dynamicProperty.Name, dynamicProperty.Val);
                                if (dictionary.Count > 0 && VimClient.MatchProperyList(filter, viewType, (IDictionary<string, object>)dictionary))
                                    moRef = objectContent.Obj;
                            }
                        }
                        else
                        {
                            moRef = objectContent.Obj;
                            break;
                        }
                    }
                }
            }
            if (moRef != null)
                entityViewBase = this.GetView(moRef, properties) as EntityViewBase;
            return entityViewBase;
        }

        public List<EntityViewBase> FindEntityViews(System.Type viewType, ManagedObjectReference beginEntity, NameValueCollection filter, string[] properties)
        {
            if (viewType == (System.Type)null)
                throw new ArgumentNullException("viewType");
            if (this._vimService == null)
                throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
            if (this._serviceContent == null)
                throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
            if (!viewType.IsSubclassOf(typeof(EntityViewBase)))
                throw new InvalidOperationException(Resources.InvalidViewTypeParam);
            IList<ViewBase> viewBaseList = (IList<ViewBase>)null;
            ManagedObjectReference beginEntity1 = beginEntity ?? this._serviceContent.RootFolder;
            string[] strArray = (string[])null;
            if (filter != null && filter.Count > 0)
            {
                string[] propertyList = new string[filter.Count];
                filter.AllKeys.CopyTo((Array)propertyList, 0);
                strArray = VimClient.ValidatePropertyPathList(viewType, propertyList);
            }
            ObjectContent[] objectContentArray = new PropertyCollector((VimClient)this, this._serviceContent.PropertyCollector).RetrieveProperties(new PropertyFilterSpec[1]
            {
        EntityViewBase.GetSearchFilterSpec((VimClient) this, beginEntity1, new PropertySpec()
        {
          All = new bool?(false),
          Type = viewType.Name,
          PathSet = strArray
        })
            });
            List<ManagedObjectReference> managedObjectReferenceList = new List<ManagedObjectReference>();
            if (objectContentArray != null)
            {
                foreach (ObjectContent objectContent in objectContentArray)
                {
                    if (beginEntity == null || !objectContent.Obj.Value.Equals(beginEntity.Value) || !objectContent.Obj.Type.Equals(beginEntity.Type))
                    {
                        if (filter != null && filter.Count > 0)
                        {
                            DynamicProperty[] propSet = objectContent.PropSet;
                            if (propSet != null)
                            {
                                Dictionary<string, object> dictionary = new Dictionary<string, object>();
                                foreach (DynamicProperty dynamicProperty in propSet)
                                    dictionary.Add(dynamicProperty.Name, dynamicProperty.Val);
                                if (dictionary.Count > 0 && VimClient.MatchProperyList(filter, viewType, (IDictionary<string, object>)dictionary))
                                    managedObjectReferenceList.Add(objectContent.Obj);
                            }
                        }
                        else
                            managedObjectReferenceList.Add(objectContent.Obj);
                    }
                }
            }
            if (managedObjectReferenceList.Count > 0)
                viewBaseList = (IList<ViewBase>)this.GetViewsByMorefs((IEnumerable<ManagedObjectReference>)managedObjectReferenceList, properties);
            List<EntityViewBase> entityViewBaseList = (List<EntityViewBase>)null;
            if (viewBaseList != null)
            {
                entityViewBaseList = new List<EntityViewBase>();
                foreach (ViewBase viewBase in (IEnumerable<ViewBase>)viewBaseList)
                {
                    EntityViewBase entityViewBase = viewBase as EntityViewBase;
                    entityViewBaseList.Add(entityViewBase);
                }
            }
            return entityViewBaseList;
        }

        public List<ViewBase> GetViews(IEnumerable<ManagedObjectReference> moRefs, params string[] properties)
        {
            if (moRefs == null)
                throw new ArgumentNullException("moRefs");
            if (this._vimService == null)
                throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
            if (this._serviceContent == null)
                throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
            Dictionary<string, PropertyFilterSpec> dictionary = new Dictionary<string, PropertyFilterSpec>();
            foreach (ManagedObjectReference moRef in moRefs)
            {
                if (dictionary.ContainsKey(moRef.Type.ToLower()))
                {
                    PropertyFilterSpec propertyFilterSpec = dictionary[moRef.Type.ToLower()];
                    ObjectSpec[] array = new List<ObjectSpec>((IEnumerable<ObjectSpec>)propertyFilterSpec.ObjectSet)
          {
            new ObjectSpec() { Obj = moRef }
          }.ToArray();
                    propertyFilterSpec.ObjectSet = array;
                }
                else
                {
                    PropertySpec propertySpec = new PropertySpec();
                    propertySpec.Type = moRef.Type;
                    if (properties != null && properties.Length != 0)
                    {
                        propertySpec.All = new bool?(false);
                        propertySpec.PathSet = VimClient.MakePropertiesCamelCase(properties);
                    }
                    else
                        propertySpec.All = new bool?(true);
                    dictionary.Add(moRef.Type.ToLower(), new PropertyFilterSpec()
                    {
                        PropSet = new PropertySpec[1] { propertySpec },
                        ObjectSet = new List<ObjectSpec>()
            {
              new ObjectSpec() { Obj = moRef }
            }.ToArray()
                    });
                }
            }
            PropertyFilterSpec[] propertyFilterSpecArray = new PropertyFilterSpec[dictionary.Values.Count];
            dictionary.Values.CopyTo(propertyFilterSpecArray, 0);
            return this.GetViews(new PropertyCollector((VimClient)this, this._serviceContent.PropertyCollector).RetrieveProperties(propertyFilterSpecArray), properties);
        }

        public List<ViewBase> GetViews(ObjectContent[] objectContent, string[] properties)
        {
            List<ViewBase> viewBaseList = new List<ViewBase>();
            foreach (ObjectContent objectContent1 in objectContent)
            {
                ConstructorInfo constructor = ViewBase.GetViewType(objectContent1.Obj.Type).GetConstructor(new System.Type[2]
                {
          typeof (VimClient),
          typeof (ManagedObjectReference)
                });
                if (constructor != (ConstructorInfo)null)
                {
                    ViewBase viewBase = (ViewBase)constructor.Invoke(new object[2]
                    {
            (object) this,
            (object) objectContent1.Obj
                    });
                    viewBase.SetViewData(objectContent1, properties);
                    viewBaseList.Add(viewBase);
                }
            }
            return viewBaseList;
        }

        public List<ViewBase> GetViewsByMorefs(IEnumerable<ManagedObjectReference> moRefs, params string[] properties)
        {
            if (moRefs == null)
                throw new ArgumentNullException("moRefs");
            if (this._vimService == null)
                throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
            if (this._serviceContent == null)
                throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
            Dictionary<string, PropertyFilterSpec> propertyFilterSpecList = new Dictionary<string, PropertyFilterSpec>();
            foreach (ManagedObjectReference moRef in moRefs)
            {
                if (propertyFilterSpecList.ContainsKey(moRef.Type.ToLower()))
                {
                    PropertyFilterSpec propertyFilterSpec = propertyFilterSpecList[moRef.Type.ToLower()];
                    ObjectSpec[] array = new List<ObjectSpec>((IEnumerable<ObjectSpec>)propertyFilterSpec.ObjectSet)
          {
            new ObjectSpec() { Obj = moRef }
          }.ToArray();
                    propertyFilterSpec.ObjectSet = array;
                }
                else
                {
                    PropertyFilterSpec resultPropertyFilterSpec;
                    Dictionary<string, List<string>> currentAllowedPropertyPath;
                    DynamicPropertyFilterSpecGenerator.Generate(moRef, properties, out resultPropertyFilterSpec, out currentAllowedPropertyPath);
                    propertyFilterSpecList.Add(moRef.Type.ToLower(), resultPropertyFilterSpec);
                }
            }
            PropertyFilterSpec[] propertyFilterSpecArray = new PropertyFilterSpec[propertyFilterSpecList.Values.Count];
            propertyFilterSpecList.Values.CopyTo(propertyFilterSpecArray, 0);
            ObjectContent[] objectContent = new PropertyCollector((VimClient)this, this._serviceContent.PropertyCollector).RetrieveProperties(propertyFilterSpecArray);
            return this.GetViewsByMorefs(moRefs, objectContent, propertyFilterSpecList);
        }

        private List<ViewBase> GetViewsByMorefs(IEnumerable<ManagedObjectReference> moRefs, ObjectContent[] objectContent, Dictionary<string, PropertyFilterSpec> propertyFilterSpecList)
        {
            List<ViewBase> viewBaseList = new List<ViewBase>();
            List<string> stringList = new List<string>();
            foreach (ManagedObjectReference moRef in moRefs)
                stringList.Add(moRef.Value);
            Dictionary<string, ObjectContent> objectContentList = new Dictionary<string, ObjectContent>();
            foreach (ObjectContent objectContent1 in objectContent)
                objectContentList.Add(objectContent1.Obj.Value, objectContent1);
            Dictionary<string, ViewBase> generatedManagedObjectList = new Dictionary<string, ViewBase>();
            foreach (ObjectContent objectContent1 in objectContent)
            {
                if (stringList.Contains(objectContent1.Obj.Value))
                {
                    ConstructorInfo constructor = ViewBase.GetViewType(objectContent1.Obj.Type).GetConstructor(new System.Type[2]
                    {
            typeof (VimClient),
            typeof (ManagedObjectReference)
                    });
                    if (constructor != (ConstructorInfo)null)
                    {
                        ViewBase currentObject = (ViewBase)constructor.Invoke(new object[2]
                        {
              (object) this,
              (object) objectContent1.Obj
                        });
                        ViewBase.SetViewData(currentObject, (string)null, (Dictionary<string, List<string>>)null, objectContentList, generatedManagedObjectList);
                        viewBaseList.Add(currentObject);
                    }
                }
            }
            return viewBaseList;
        }

        public ViewBase GetView(ManagedObjectReference moRef, string[] properties)
        {
            if (moRef == null)
                throw new ArgumentNullException("moRef");
            System.Type viewType = ViewBase.GetViewType(moRef.Type);
            if (viewType == (System.Type)null || !viewType.IsSubclassOf(typeof(ViewBase)))
                throw new InvalidOperationException(string.Format(Resources.InvalidViewType, (object)viewType));
            ViewBase viewBase = (ViewBase)viewType.GetConstructor(new System.Type[2]
            {
        typeof (VimClient),
        typeof (ManagedObjectReference)
            }).Invoke(new object[2]
            {
        (object) this,
        (object) moRef
            });
            string[] strArray = properties;
            viewBase.UpdateViewData(strArray);
            return viewBase;
        }

        public void Disconnect()
        {
            this.Logout();
            this._vimService = (VimPortType)null;
            this._serviceContent = (ServiceContent)null;
        }

        public void SaveSession(string fileName)
        {
            if (this._vimService == null)
                throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
            Cookie sessionCookie = this.TryGetSessionCookie(new Uri(this.ServiceUrl));
            if (sessionCookie == null)
                throw new InvalidOperationException(Resources.SessionCookieNotInitialized);
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                new BinaryFormatter().Serialize((Stream)fileStream, (object)sessionCookie);
        }

        public void LoadSession(string fileName)
        {
            if (this._vimService == null)
                this.Connect();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                this.SessionSecret = (new BinaryFormatter().Deserialize((Stream)fileStream) as Cookie).Value;
            new SessionManager((VimClient)this, this.ServiceContent.SessionManager).UpdateViewData();
        }

        public bool IsVimVersionOrHigher(VimVersion version)
        {
            int result1;
            int.TryParse(this.Version.ToString().Substring(3).PadRight(3, '0'), out result1);
            int result2;
            int.TryParse(version.ToString().Substring(3).PadRight(3, '0'), out result2);
            return result1 >= result2;
        }

        public object WaitForTask(ManagedObjectReference taskReference)
        {
            Task view = (Task)this.GetView(taskReference, (string[])null);
            TaskInfo info;
            while (true)
            {
                info = view.Info;
                if (info.State != TaskInfoState.success)
                {
                    if (info.State != TaskInfoState.error)
                    {
                        Thread.Sleep(2000);
                        view.UpdateViewData();
                    }
                    else
                        goto label_4;
                }
                else
                    break;
            }
            return info.Result;
            label_4:
            MethodFault fault = info.Error.Fault;
            throw new VimException(info.Error.LocalizedMessage, fault);
        }

        private Binding GetBinding()
        {
            TimeSpan timeSpan1 = this._serviceTimeout <= 0 ? TimeSpan.MaxValue : TimeSpan.FromMilliseconds((double)this._serviceTimeout);
            BasicHttpsBinding basicHttpsBinding = new BasicHttpsBinding();
            int num1 = 1;
            basicHttpsBinding.AllowCookies = num1 != 0;
            TimeSpan timeSpan2 = timeSpan1;
            basicHttpsBinding.CloseTimeout = timeSpan2;
            TimeSpan timeSpan3 = timeSpan1;
            basicHttpsBinding.OpenTimeout = timeSpan3;
            TimeSpan timeSpan4 = timeSpan1;
            basicHttpsBinding.ReceiveTimeout = timeSpan4;
            TimeSpan timeSpan5 = timeSpan1;
            basicHttpsBinding.SendTimeout = timeSpan5;
            long num2 = 1073741824;
            basicHttpsBinding.MaxReceivedMessageSize = num2;
            return (Binding)basicHttpsBinding;
        }

        private VimPortType CreateClientChannel()
        {
            ChannelFactory<VimPortType> channelFactory = new ChannelFactory<VimPortType>(this.GetBinding(), new EndpointAddress(new Uri(this.ServiceUrl), new AddressHeader[0]));
            if (this.UserAgent != null)
                channelFactory.Endpoint.Behaviors.Add((IEndpointBehavior)new UserAgentBehavior(this.UserAgent));
            return channelFactory.CreateChannel();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) //free managed resources if any
            {
                //if (_vimService != null) { _vimService.Dispose(); }
            }
            // free native resources if there are any.  
            //_certificateError = null;
            _serviceContent = null;
            _serviceUrl = null;
            _vimService = null;
            //_serializerCache.Clear();
        }
    }
}
