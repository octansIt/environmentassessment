using EnvironmentAssessment.Collector;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace EnvironmentAssessment.Common.VISoap
{
	public class VimClient : IClient
	{
		internal const ushort DefaultPort = 443;
		private const string SESSION_COOKIE_NAME = "vmware_soap_session";
		private EventHandler<CertificateErrorEventArg> _certificateError;
		private ServiceContent _serviceContent;
		private VimVersion _version;
		private SoapHttpClientProtocol _vimService;
		private string _serviceUrl;
        private int _serviceTimeout = COptions.VI_Timeout;
		private static readonly object _serializerCacheLock = new object();
		private static readonly Dictionary<Type, XmlSerializer> _serializerCache = new Dictionary<Type, XmlSerializer>();
		public VimVersion Version
		{
			get
			{
				return this._version;
			}
		}
		public SoapHttpClientProtocol VimService
		{
			get
			{
				return this._vimService;
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
		public EventHandler<CertificateErrorEventArg> CertificateError
		{
			get
			{
				return this._certificateError;
			}
			set
			{
				this._certificateError = value;
			}
		}
		private bool RemoteCertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			bool flag = true;
			if (this.CertificateError != null)
			{
				CertificateErrorEventArg certificateErrorEventArg = new CertificateErrorEventArg(certificate, chain, sslPolicyErrors, flag, sender);
				this.CertificateError(this, certificateErrorEventArg);
				flag = certificateErrorEventArg.IgnoreError;
			}
			return flag;
		}
		private static bool MatchProperyList(NameValueCollection filter, Type viewType, IDictionary<string, object> propList)
		{
			bool result = true;
			foreach (string inputProperty in filter.Keys)
			{
				string text = VimClient.ValidatePropertyPath(viewType, inputProperty);
				if (!propList.ContainsKey(text))
				{
					result = false;
					break;
				}
				string pattern = filter[text];
				if (propList[text] is ManagedObjectReference[])
				{
					bool flag = false;
					ManagedObjectReference[] array = (ManagedObjectReference[])propList[text];
					for (int i = 0; i < array.Length; i++)
					{
						ManagedObjectReference managedObjectReference = array[i];
						Match match = Regex.Match(managedObjectReference.Value, pattern, RegexOptions.IgnoreCase);
						flag = (flag || match.Success);
					}
					if (!flag)
					{
						result = false;
						break;
					}
				}
				else
				{
					string input;
					if (propList[text] is ManagedObjectReference)
					{
						input = ((ManagedObjectReference)propList[text]).Value;
					}
					else
					{
						if (propList[text] is string[])
						{
							input = string.Join(",", propList[text] as string[]);
						}
						else
						{
							input = propList[text].ToString();
						}
					}
					Match match2 = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
					if (!match2.Success)
					{
						result = false;
						break;
					}
				}
			}
			return result;
		}
		private static string[] ValidatePropertyPathList(Type viewType, string[] propertyList)
		{
			List<string> list = new List<string>();
			if (propertyList != null && propertyList.Length > 0)
			{
				for (int i = 0; i < propertyList.Length; i++)
				{
					string inputProperty = propertyList[i];
					string item = VimClient.ValidatePropertyPath(viewType, inputProperty);
					list.Add(item);
				}
			}
			if (list.Count != 0)
			{
				return list.ToArray();
			}
			return null;
		}
		private static string ValidatePropertyPath(Type viewType, string inputProperty)
		{
			Type type = viewType;
			string[] array = inputProperty.Split(new char[]
			{
				'.'
			});
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				PropertyInfo propertyInfo = null;
				if (type != null)
				{
					Dictionary<string, PropertyInfo> typeProperties = ViReflectionCache.GetTypeProperties(type);
					typeProperties.TryGetValue(array[i].ToLower(), out propertyInfo);
				}
				if (propertyInfo != null)
				{
					type = propertyInfo.PropertyType;
					array2[i] = VimClient.MakeCamelCase(propertyInfo.Name);
				}
				else
				{
					array2[i] = VimClient.MakeCamelCase(array[i]);
					type = null;
				}
			}
			return string.Join(".", array2);
		}
		internal static string MakeCamelCase(string s)
		{
			string result = s;
			if (!string.IsNullOrEmpty(s))
			{
				StringBuilder stringBuilder = new StringBuilder(s);
				if (stringBuilder.Length > 0)
				{
					stringBuilder[0] = char.ToLower(stringBuilder[0]);
				}
				result = stringBuilder.ToString();
			}
			return result;
		}
		internal static string MakePropertyCamelCase(string property)
		{
			string result = property;
			if (!string.IsNullOrEmpty(property))
			{
				string[] array = property.Split(new char[]
				{
					'.'
				});
				string[] array2 = new string[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = VimClient.MakeCamelCase(array[i]);
				}
				result = string.Join(".", array2);
			}
			return result;
		}
		internal static string[] MakePropertiesCamelCase(string[] properties)
		{
			string[] array = null;
			if (properties != null)
			{
				array = new string[properties.Length];
				for (int i = 0; i < properties.Length; i++)
				{
					array[i] = VimClient.MakePropertyCamelCase(properties[i]);
				}
			}
			return array;
		}
        
		public MethodFault GetVIServerFault(SoapException soapEx)
		{
			if (soapEx == null)
			{
				throw new ArgumentNullException("soapEx");
			}
			MethodFault result = null;
			if (soapEx.Detail != null)
			{
				XmlNode xmlNode = null;
				foreach (XmlNode xmlNode2 in soapEx.Detail.ChildNodes)
				{
					if (!(xmlNode2 is XmlWhitespace))
					{
						xmlNode = xmlNode2;
						break;
					}
				}
				if (xmlNode != null)
				{
					string text = xmlNode.LocalName;
					if (xmlNode.LocalName.EndsWith("Fault"))
					{
						text = text.Substring(0, text.Length - 5);
					}
					xmlNode.InnerXml = xmlNode.InnerXml.Replace("xsd:", "");
					try
					{
						XmlReader xmlReader = new XmlNodeReader(xmlNode);
						Type vimType = VersionUtils.GetVimType(text, this.Version);
						XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(xmlNode.LocalName);
						xmlRootAttribute.Namespace = VersionUtils.GetVimServiceTNS(this.Version);
						object serializerCacheLock;
						Monitor.Enter(serializerCacheLock = VimClient._serializerCacheLock);
						XmlSerializer xmlSerializer;
						try
						{
							if (!VimClient._serializerCache.TryGetValue(vimType, out xmlSerializer))
							{
								xmlSerializer = new XmlSerializer(vimType, xmlRootAttribute);
								VimClient._serializerCache[vimType] = xmlSerializer;
							}
						}
						finally
						{
							Monitor.Exit(serializerCacheLock);
						}
						result = (VIConvert.ToVim(xmlSerializer.Deserialize(xmlReader)) as MethodFault);
					}
					catch (Exception)
					{
						result = null;
					}
				}
			}
			return result;
		}
		public VimClient()
		{
		}
		public VimClient(SoapHttpClientProtocol service, object serviceContent)
		{
			if (service == null)
			{
				throw new ArgumentNullException("service");
			}
			if (serviceContent == null)
			{
				throw new ArgumentNullException("serviceContent");
			}
			ServiceContent serviceContent2 = (ServiceContent)VIConvert.ToVim(serviceContent);
			this._version = VersionUtils.GetVersionFromApi(serviceContent2.About.ApiVersion);
			this._serviceUrl = service.Url;
			Type vimServiceType = VersionUtils.GetVimServiceType(this._version);
			if (vimServiceType.Equals(service.GetType()))
			{
				this._vimService = service;
				this._serviceContent = serviceContent2;
				return;
			}
			this._vimService = (SoapHttpClientProtocol)Activator.CreateInstance(vimServiceType);
			this._vimService.Url = this._serviceUrl;
			this._vimService.Timeout = service.Timeout;
			this._vimService.CookieContainer = new CookieContainer();
			Uri uri = new Uri(service.Url);
			Cookie cookie = service.CookieContainer.GetCookies(uri)[0];
			this._vimService.CookieContainer.Add(cookie);
			ServiceInstance serviceInstance = new ServiceInstance(this, new ManagedObjectReference
			{
				Type = "ServiceInstance",
				Value = "ServiceInstance"
			});
			this._serviceContent = serviceInstance.RetrieveServiceContent();
		}
		public ServiceContent Connect()
		{
			if (string.IsNullOrEmpty(this._serviceUrl))
			{
				throw new InvalidOperationException(Resources.InvalidServiceUrl);
			}
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.RemoteCertificateValidation);
			this._version = VersionUtils.GetVIServerVersion(this._serviceUrl);
			this._vimService = (SoapHttpClientProtocol)Activator.CreateInstance(VersionUtils.GetVimServiceType(this.Version));
			this._vimService.Url = this.ServiceUrl;
			this._vimService.CookieContainer = new CookieContainer();
			this._vimService.Timeout = this._serviceTimeout;
			ServiceInstance serviceInstance = new ServiceInstance(this, new ManagedObjectReference
			{
				Type = "ServiceInstance",
				Value = "ServiceInstance"
			});
			this._serviceContent = serviceInstance.RetrieveServiceContent();
			return this._serviceContent;
		}
		public ServiceContent Connect(string serviceUrl)
		{
			this.ServiceUrl = serviceUrl;
			return this.Connect();
		}
		public ServiceContent Connect(string server, CommunicationProtocol? protocol, ushort? port)
		{
			if (!protocol.HasValue)
			{
				protocol = new CommunicationProtocol?(CommunicationProtocol.Https);
			}
			if (string.IsNullOrEmpty(server))
			{
				server = "127.0.0.1";
			}
			if (!port.HasValue && protocol == CommunicationProtocol.Https)
			{
				port = new ushort?(443);
			}
			this.ServiceUrl = string.Concat(new string[]
			{
				protocol.ToString().ToLower(),
				"://",
				server,
				port.HasValue ? (":" + port.Value) : string.Empty,
				"/sdk"
			});
			return this.Connect();
		}

        internal UserSession Login(ISession Session)
        {
            string error = "";
            string logintime = "";
            UserSession us = null;
            this.ServiceUrl = "https://" + Session.Server.Name + "/sdk";
            ServiceTimeout = COptions.VI_Login_Timeout;

            try { 
                if (this._vimService == null || this._serviceContent == null) { this.Connect(); } 
            }
            catch (System.Net.WebException ex)
            {
                Common.Log.Write("[ViSoap] Connecting to 'https://" + Session.Server.Name + "/sdk' failed: " + ex.Message);
                Session.Error = ex.Message;
                return null;
            }

            SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
            try
            {
                Common.Log.Write("[ViSoap] Connecting to 'https://" + Session.Server.Name + "/sdk' using specified credentials [" + Session.Server.UserName + "]");
                us = sessionManager.Login(Session.Server.UserName, Session.Server.UserPassword, null);
                logintime = us.LoginTime.ToString();
            }
            catch (VISoap.VimException ex)
            {
                error = ex.Message;
            }
            if (logintime.Length > 0)
            {
                Common.Log.Write("[ViSoap] Logged into 'https://" + Session.Server.Name + "/sdk' at " + us.LoginTime + " (" + this.Version.ToString().ToLower() + ").");
                return us;
            }
            else { Common.Log.Write("[ViSoap] Login into 'https://" + Session.Server.Name + "/sdk' failed: " + error); Session.Error = error; return null; }

        }

		public UserSession Login(string username, string password)
		{
			if (this._vimService == null || this._serviceContent == null)
			{
				this.Connect();
			}
			SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
			return sessionManager.Login(username, password, null);
		}
		public UserSession Login(string serviceUrl, string username, string password)
		{
			this.Connect(serviceUrl);
			SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
			return sessionManager.Login(username, password, null);
		}

        internal UserSession LoginSSPI(ISession Session)
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
                Common.Log.Write("[ViSoap] Connecting to 'https://" + Session.Server.Name + "/sdk' failed: " + ex.Message);
                Session.Error = ex.Message;
                return null;
            }

            SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
            
            if (sessionManager != null)
            {
                Boolean flag = true;

                // get server's fqdn for cross-domain authentication
                string FQDN = Session.Server.Name.Substring(Session.Server.Name.IndexOf('.'));
                Common.SSPI.Credentials.CClientCredential clientCred = new Common.SSPI.Credentials.CClientCredential(SSPI.CPackageNames.Negotiate);

                Common.SSPI.Contexts.CClientContext clientContext = null;

                string os = this.ServiceContent.About.OsType;
                if (os.Contains("win")) {
                    string serviceprincipal = "host/" + Session.Server.Name + "@" + FQDN;
                    clientContext = new Common.SSPI.Contexts.CClientContext(clientCred, serviceprincipal, Common.SSPI.Contexts.CContextAttrib.Zero);
                    Log.Write("[SSPI] Initialized client context for connection to Windows-based vCenter (" + os + ") using service principal: " + serviceprincipal);
                }
                else
                {
                    string serviceprincipal = "host/" + Session.Server.Name;
                    clientContext = new Common.SSPI.Contexts.CClientContext(clientCred, serviceprincipal, SSPI.Contexts.CContextAttrib.Zero);
                    Log.Write("[SSPI] Initialized client context for connection to Linux-based vCenter (" + os + ") using service principal: " + serviceprincipal);
                }
                
                byte[] clientToken = null;
                byte[] serverToken = null;
                string clientLocale = "en"; //using default locale, should work according to documentation
                bool retry = false;

                Common.SSPI.CSecurityStatus clientStatus;

                while (flag)
                {
                    try //sspi authentication
                    {
                        clientStatus = clientContext.Init(serverToken, out clientToken);
                        Common.Log.Write("[ViSoap] Connecting to 'https://" + Session.Server.Name + "/sdk' using Windows Session Credentials [" + Environment.UserDomainName + @"\" + Environment.UserName + "] (SSPI Token)");
                        Common.Log.Write("[SSPI] Client token sent <base64Token>" + Convert.ToBase64String(clientToken) + "</base64Token><locale>" + clientLocale + "</locale>", Log.Verbosity.Debug);
                        us = sessionManager.LoginBySSPI(Convert.ToBase64String(clientToken), clientLocale);
                        flag = false;
                    }
                    catch (VISoap.VimException e)
                    {
                        if (e.MethodFault is SSPIChallenge)
                        {
                            Common.Log.Write("[ViSoap] Responding to SSPI challenge from 'https://" + Session.Server.Name + "/sdk' (SSPI challenge response)");
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
                    catch (Common.SSPI.CSSPIException e)
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
                Common.Log.Write("[ViSoap] Logged into 'https://" + Session.Server.Name + "/sdk' at " + us.LoginTime + " (" + this.Version.ToString().ToLower() + ").");
                return us;
            }
            else
            {
                Common.Log.Write("[ViSoap] Login into 'https://" + Session.Server.Name + "/sdk' failed: " + error);
                Session.Error = error;
                return null;
            }
        }

		public void Logout()
		{
			if (this._serviceContent == null)
			{
				throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
			}
			SessionManager sessionManager = new SessionManager(this, this._serviceContent.SessionManager);
			sessionManager.Logout();
		}
		public UserSession ConnectToSession(string serviceUrl, string soapSessionId)
		{
			if (string.IsNullOrEmpty(soapSessionId))
			{
				throw new InvalidOperationException(Resources.SessionIdNotInitialized);
			}
			this.Connect(serviceUrl);
			this._vimService.CookieContainer = new CookieContainer();
			soapSessionId = "\"" + soapSessionId.Trim(new char[] { '"' }) + "\"";
			this._vimService.CookieContainer.Add(new Cookie("vmware_soap_session", soapSessionId, "/", new Uri(serviceUrl).Host));
			SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
			sessionManager.UpdateViewData();
			return sessionManager.CurrentSession;
		}
		public EntityViewBase FindEntityView(Type viewType, ManagedObjectReference beginEntity, NameValueCollection filter, string[] properties)
		{
			if (viewType == null)
			{
				throw new ArgumentNullException("viewType");
			}
			if (this._vimService == null)
			{
				throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
			}
			if (this._serviceContent == null)
			{
				throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
			}
			if (!viewType.IsSubclassOf(typeof(EntityViewBase)))
			{
				throw new InvalidOperationException(Resources.InvalidViewTypeParam);
			}
			EntityViewBase result = null;
			ManagedObjectReference managedObjectReference = beginEntity;
			if (managedObjectReference == null)
			{
				managedObjectReference = this._serviceContent.RootFolder;
			}
			string[] array = null;
			if (filter != null && filter.Count > 0)
			{
				array = new string[filter.Count];
				filter.AllKeys.CopyTo(array, 0);
				array = VimClient.ValidatePropertyPathList(viewType, array);
			}
			PropertyFilterSpec searchFilterSpec = EntityViewBase.GetSearchFilterSpec(this, managedObjectReference, new PropertySpec
			{
				All = new bool?(false),
				Type = viewType.Name,
				PathSet = array
			});
			PropertyCollector propertyCollector = new PropertyCollector(this, this._serviceContent.PropertyCollector);
			ObjectContent[] array2 = propertyCollector.RetrieveProperties(new PropertyFilterSpec[]
			{
				searchFilterSpec
			});
			ManagedObjectReference managedObjectReference2 = null;
			if (array2 != null)
			{
				ObjectContent[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					ObjectContent objectContent = array3[i];
					if (beginEntity == null || !objectContent.Obj.Value.Equals(beginEntity.Value) || !objectContent.Obj.Type.Equals(beginEntity.Type))
					{
						if (filter == null || filter.Count <= 0)
						{
							managedObjectReference2 = objectContent.Obj;
							break;
						}
						DynamicProperty[] propSet = objectContent.PropSet;
						if (propSet != null)
						{
							Dictionary<string, object> dictionary = new Dictionary<string, object>();
							DynamicProperty[] array4 = propSet;
							for (int j = 0; j < array4.Length; j++)
							{
								DynamicProperty dynamicProperty = array4[j];
								dictionary.Add(dynamicProperty.Name, dynamicProperty.Val);
							}
							if (dictionary.Count > 0 && VimClient.MatchProperyList(filter, viewType, dictionary))
							{
								managedObjectReference2 = objectContent.Obj;
							}
						}
					}
				}
			}
			if (managedObjectReference2 != null)
			{
				result = (this.GetView(managedObjectReference2, properties) as EntityViewBase);
			}
			return result;
		}
		public List<EntityViewBase> FindEntityViews(Type viewType, ManagedObjectReference beginEntity, NameValueCollection filter, string[] properties)
		{
			if (viewType == null)
			{
				throw new ArgumentNullException("viewType");
			}
			if (this._vimService == null)
			{
				throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
			}
			if (this._serviceContent == null)
			{
				throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
			}
			if (!viewType.IsSubclassOf(typeof(EntityViewBase)))
			{
				throw new InvalidOperationException(Resources.InvalidViewTypeParam);
			}
			IList<ViewBase> list = null;
			ManagedObjectReference managedObjectReference = beginEntity;
			if (managedObjectReference == null)
			{
				managedObjectReference = this._serviceContent.RootFolder;
			}
			string[] array = null;
			if (filter != null && filter.Count > 0)
			{
				array = new string[filter.Count];
				filter.AllKeys.CopyTo(array, 0);
				array = VimClient.ValidatePropertyPathList(viewType, array);
			}
			PropertyFilterSpec searchFilterSpec = EntityViewBase.GetSearchFilterSpec(this, managedObjectReference, new PropertySpec
			{
				All = new bool?(false),
				Type = viewType.Name,
				PathSet = array
			});
			PropertyCollector propertyCollector = new PropertyCollector(this, this._serviceContent.PropertyCollector);
			ObjectContent[] array2 = propertyCollector.RetrieveProperties(new PropertyFilterSpec[]
			{
				searchFilterSpec
			});
			List<ManagedObjectReference> list2 = new List<ManagedObjectReference>();
			if (array2 != null)
			{
				ObjectContent[] array3 = array2;
				for (int i = 0; i < array3.Length; i++)
				{
					ObjectContent objectContent = array3[i];
					if (beginEntity == null || !objectContent.Obj.Value.Equals(beginEntity.Value) || !objectContent.Obj.Type.Equals(beginEntity.Type))
					{
						if (filter != null && filter.Count > 0)
						{
							DynamicProperty[] propSet = objectContent.PropSet;
							if (propSet != null)
							{
								Dictionary<string, object> dictionary = new Dictionary<string, object>();
								DynamicProperty[] array4 = propSet;
								for (int j = 0; j < array4.Length; j++)
								{
									DynamicProperty dynamicProperty = array4[j];
									dictionary.Add(dynamicProperty.Name, dynamicProperty.Val);
								}
								if (dictionary.Count > 0 && VimClient.MatchProperyList(filter, viewType, dictionary))
								{
									list2.Add(objectContent.Obj);
								}
							}
						}
						else
						{
							list2.Add(objectContent.Obj);
						}
					}
				}
			}
			if (list2.Count > 0)
			{
				list = this.GetViewsByMorefs(list2, properties);
			}
			List<EntityViewBase> list3 = null;
			if (list != null)
			{
				list3 = new List<EntityViewBase>();
				foreach (ViewBase current in list)
				{
					EntityViewBase item = current as EntityViewBase;
					list3.Add(item);
				}
			}
			return list3;
		}
		public List<ViewBase> GetViews(IEnumerable<ManagedObjectReference> moRefs, params string[] properties)
		{
			if (moRefs == null)
			{
				throw new ArgumentNullException("moRefs");
			}
			if (this._vimService == null)
			{
				throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
			}
			if (this._serviceContent == null)
			{
				throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
			}
			Dictionary<string, PropertyFilterSpec> dictionary = new Dictionary<string, PropertyFilterSpec>();
			foreach (ManagedObjectReference current in moRefs)
			{
				if (dictionary.ContainsKey(current.Type.ToLower()))
				{
					PropertyFilterSpec propertyFilterSpec = dictionary[current.Type.ToLower()];
					propertyFilterSpec.ObjectSet = new List<ObjectSpec>(propertyFilterSpec.ObjectSet)
					{
						new ObjectSpec
						{
							Obj = current
						}
					}.ToArray();
				}
				else
				{
					PropertySpec propertySpec = new PropertySpec();
					propertySpec.Type = current.Type;
					if (properties != null && properties.Length > 0)
					{
						propertySpec.All = new bool?(false);
						propertySpec.PathSet = VimClient.MakePropertiesCamelCase(properties);
					}
					else
					{
						propertySpec.All = new bool?(true);
					}
					List<ObjectSpec> list = new List<ObjectSpec>();
					list.Add(new ObjectSpec
					{
						Obj = current
					});
					PropertyFilterSpec propertyFilterSpec2 = new PropertyFilterSpec();
					propertyFilterSpec2.PropSet = new PropertySpec[]
					{
						propertySpec
					};
					propertyFilterSpec2.ObjectSet = list.ToArray();
					dictionary.Add(current.Type.ToLower(), propertyFilterSpec2);
				}
			}
			PropertyFilterSpec[] array = new PropertyFilterSpec[dictionary.Values.Count];
			dictionary.Values.CopyTo(array, 0);
			PropertyCollector propertyCollector = new PropertyCollector(this, this._serviceContent.PropertyCollector);
			ObjectContent[] objectContent = propertyCollector.RetrieveProperties(array);
			return this.GetViews(objectContent, properties);
		}
		public List<ViewBase> GetViews(ObjectContent[] objectContent, string[] properties)
		{
			List<ViewBase> list = new List<ViewBase>();
			for (int i = 0; i < objectContent.Length; i++)
			{
				ObjectContent objectContent2 = objectContent[i];
				Type viewType = ViewBase.GetViewType(objectContent2.Obj.Type);
				ConstructorInfo constructor = viewType.GetConstructor(new Type[]
				{
					typeof(VimClient),
					typeof(ManagedObjectReference)
				});
				if (constructor != null)
				{
					ViewBase viewBase = (ViewBase)constructor.Invoke(new object[]
					{
						this,
						objectContent2.Obj
					});
					viewBase.SetViewData(objectContent2, properties);
					list.Add(viewBase);
				}
			}
			return list;
		}
		public List<ViewBase> GetViewsByMorefs(IEnumerable<ManagedObjectReference> moRefs, params string[] properties)
		{
			if (moRefs == null)
			{
				throw new ArgumentNullException("moRefs");
			}
			if (this._vimService == null)
			{
				throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
			}
			if (this._serviceContent == null)
			{
				throw new InvalidOperationException(Resources.ServiceContentNotInitialized);
			}
			Dictionary<string, PropertyFilterSpec> dictionary = new Dictionary<string, PropertyFilterSpec>();
			foreach (ManagedObjectReference current in moRefs)
			{
				if (dictionary.ContainsKey(current.Type.ToLower()))
				{
					PropertyFilterSpec propertyFilterSpec = dictionary[current.Type.ToLower()];
					propertyFilterSpec.ObjectSet = new List<ObjectSpec>(propertyFilterSpec.ObjectSet)
					{
						new ObjectSpec
						{
							Obj = current
						}
					}.ToArray();
				}
				else
				{
					PropertyFilterSpec value;
					Dictionary<string, List<string>> dictionary2;
					DynamicPropertyFilterSpecGenerator.Generate(current, properties, out value, out dictionary2);
					dictionary.Add(current.Type.ToLower(), value);
				}
			}
			PropertyFilterSpec[] array = new PropertyFilterSpec[dictionary.Values.Count];
			dictionary.Values.CopyTo(array, 0);
			PropertyCollector propertyCollector = new PropertyCollector(this, this._serviceContent.PropertyCollector);
			ObjectContent[] objectContent = propertyCollector.RetrieveProperties(array);
			return this.GetViewsByMorefs(moRefs, objectContent, dictionary);
		}
		private List<ViewBase> GetViewsByMorefs(IEnumerable<ManagedObjectReference> moRefs, ObjectContent[] objectContent, Dictionary<string, PropertyFilterSpec> propertyFilterSpecList)
		{
			List<ViewBase> list = new List<ViewBase>();
			List<string> list2 = new List<string>();
			foreach (ManagedObjectReference current in moRefs)
			{
				list2.Add(current.Value);
			}
			Dictionary<string, ObjectContent> dictionary = new Dictionary<string, ObjectContent>();
			for (int i = 0; i < objectContent.Length; i++)
			{
				ObjectContent objectContent2 = objectContent[i];
				dictionary.Add(objectContent2.Obj.Value, objectContent2);
			}
			Dictionary<string, ViewBase> generatedManagedObjectList = new Dictionary<string, ViewBase>();
			for (int j = 0; j < objectContent.Length; j++)
			{
				ObjectContent objectContent3 = objectContent[j];
				if (list2.Contains(objectContent3.Obj.Value))
				{
					Type viewType = ViewBase.GetViewType(objectContent3.Obj.Type);
					ConstructorInfo constructor = viewType.GetConstructor(new Type[]
					{
						typeof(VimClient),
						typeof(ManagedObjectReference)
					});
					if (constructor != null)
					{
						ViewBase viewBase = (ViewBase)constructor.Invoke(new object[]
						{
							this,
							objectContent3.Obj
						});
						ViewBase.SetViewData(viewBase, null, null, dictionary, generatedManagedObjectList);
						list.Add(viewBase);
					}
				}
			}
			return list;
		}
		public ViewBase GetView(ManagedObjectReference moRef, string[] properties)
		{
			if (moRef == null)
			{
				throw new ArgumentNullException("moRef");
			}
			Type viewType = ViewBase.GetViewType(moRef.Type);
			if (viewType == null || !viewType.IsSubclassOf(typeof(ViewBase)))
			{
				string message = string.Format(Resources.InvalidViewType, viewType);
				throw new InvalidOperationException(message);
			}
			ConstructorInfo constructor = viewType.GetConstructor(new Type[]
			{
				typeof(VimClient),
				typeof(ManagedObjectReference)
			});
			ViewBase viewBase = (ViewBase)constructor.Invoke(new object[]
			{
				this,
				moRef
			});
			viewBase.UpdateViewData(properties);
			return viewBase;
		}
		public void Disconnect()
		{
			this.Logout();
			this._vimService = null;
			this._serviceContent = null;
		}
		public void SaveSession(string fileName)
		{
			if (this._vimService == null)
			{
				throw new InvalidOperationException(Resources.VimWebServiceNotInitialized);
			}
			Uri uri = new Uri(this._vimService.Url);
			CookieCollection cookies = this._vimService.CookieContainer.GetCookies(uri);
			Cookie cookie = null;
			foreach (Cookie cookie2 in cookies)
			{
				if (cookie2.Name.Equals("vmware_soap_session", StringComparison.OrdinalIgnoreCase))
				{
					cookie = cookie2;
					break;
				}
			}
			if (cookie == null)
			{
				throw new InvalidOperationException(Resources.SessionCookieNotInitialized);
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			try
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(fileStream, cookie);
			}
			finally
			{
				fileStream.Close();
			}
		}
		public void LoadSession(string fileName)
		{
			if (this._vimService == null)
			{
				this.Connect();
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Open);
			try
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				Cookie cookie = binaryFormatter.Deserialize(fileStream) as Cookie;
				this._vimService.CookieContainer = new CookieContainer();
				this._vimService.CookieContainer.Add(cookie);
			}
			finally
			{
				fileStream.Close();
			}
			SessionManager sessionManager = new SessionManager(this, this.ServiceContent.SessionManager);
			sessionManager.UpdateViewData();
		}
		public bool IsVimVersionOrHigher(VimVersion version)
		{
			string text = this.Version.ToString();
			int num;
			int.TryParse(text.Substring(3).PadRight(3, '0'), out num);
			string text2 = version.ToString();
			int num2;
			int.TryParse(text2.Substring(3).PadRight(3, '0'), out num2);
			return num >= num2;
		}
		public static List<Type> GetSupportedVimServiceTypes()
		{
			List<Type> list = new List<Type>();
			foreach (VimVersion ver in Enum.GetValues(typeof(VimVersion)))
			{
				list.Add(VersionUtils.GetVimServiceType(ver));
			}
			return list;
		}
		public object WaitForTask(ManagedObjectReference taskReference)
		{
			Task task = (Task)this.GetView(taskReference, null);
			TaskInfo info;
			while (true)
			{
				info = task.Info;
				if (info.State == TaskInfoState.success)
				{
					break;
				}
				if (info.State == TaskInfoState.error)
				{
					goto Block_2;
				}
                Thread.Sleep(Common.COptions.VI_Thread_Wait); // zzz - wonder if this can be faster
				task.UpdateViewData();
			}
			return info.Result;
			Block_2:
			MethodFault fault = info.Error.Fault;
			string localizedMessage = info.Error.LocalizedMessage;
			throw new VimException(localizedMessage, fault);
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
                if (_vimService != null) { _vimService.Dispose(); }
            }
            // free native resources if there are any.  
            _certificateError = null;
            _serviceContent = null;
            _serviceUrl = null;
            _vimService = null;
            _serializerCache.Clear();
        }
    }
}
