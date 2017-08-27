using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
        internal static class FaultUtility
        {
            public static VimException HandleFault(FaultException faultException)
            {
                MethodFault viServerFault = FaultUtility.GetVIServerFault(faultException);
                return new VimException(faultException.Message, viServerFault, (Exception)faultException);
            }

            private static MethodFault GetVIServerFault(FaultException soapEx)
            {
                if (soapEx == null)
                    throw new ArgumentNullException("soapEx");
                PropertyInfo property = soapEx.GetType().GetTypeInfo().GetProperty("Detail");
                VimApi_65.MethodFault methodFault;
                if (property != (PropertyInfo)null)
                {
                    methodFault = property.GetValue((object)soapEx) as VimApi_65.MethodFault;
                }
                else
                {
                    MessageFault messageFault = soapEx.CreateMessageFault();
                    XmlSerializer xmlSerializer = FaultUtility.GetFaultSerializer();
                    if (xmlSerializer == null)
                    {
                    /* XElement xelement = (XElement)XNode.ReadFrom((XmlReader)messageFault.GetReaderAtDetailContents());
                    System.Type type = typeof(VimApi_65.MethodFault).Assembly.GetType(string.Format("{0}.{1}", (object)typeof(VimApi_65.MethodFault).Namespace, (object)xelement.Attribute(XName.Get("type", "http://www.w3.org/2001/XMLSchema-instance")).Value));
                    XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(xelement.Name.LocalName);
                    // ISSUE: variable of the null type
                    __Null local1 = null;
                    // ISSUE: variable of the null type
                    __Null local2 = null;
                    XmlRootAttribute root = xmlRootAttribute;
                    string defaultNamespace = "urn:vim25";
                    xmlSerializer = new XmlSerializer(type, (XmlAttributeOverrides)local1, (System.Type[])local2, root, defaultNamespace); */
                        XElement xElement = (XElement)XNode.ReadFrom(messageFault.GetReaderAtDetailContents());
                        XAttribute xAttribute = xElement.Attribute(XName.Get("type", "http://www.w3.org/2001/XMLSchema-instance"));
                        string name = string.Format("{0}.{1}", typeof(VimApi_65.MethodFault).Namespace, xAttribute.Value);
                        Type arg_D0_0 = typeof(VimApi_65.MethodFault).Assembly.GetType(name);
                        XmlRootAttribute root = new XmlRootAttribute(xElement.Name.LocalName);
                        xmlSerializer = new XmlSerializer(arg_D0_0, null, null, root, "urn:vim25");
                    }
                    StringReader stringReader = new StringReader(messageFault.GetDetail<XElement>().ToString().Replace("xsd:", ""));
                    using (XmlReader xmlReader = XmlReader.Create((TextReader)stringReader, new XmlReaderSettings()
                    {
                        ConformanceLevel = ConformanceLevel.Fragment,
                        CloseInput = true
                    }))
                    {
                        int content = (int)xmlReader.MoveToContent();
                        methodFault = xmlSerializer.Deserialize(xmlReader) as VimApi_65.MethodFault;
                    }
                }
                return VIConvert.ToVim((object)methodFault) as MethodFault;
            }

            private static XmlSerializer GetFaultSerializer()
            {
                XmlSerializerAssemblyAttribute customAttribute = typeof(VimPortType).GetCustomAttribute<XmlSerializerAssemblyAttribute>();
                if (customAttribute == null)
                    return (XmlSerializer)null;
                System.Type type = (customAttribute.AssemblyName != null ? Assembly.Load(customAttribute.AssemblyName) : typeof(VimPortType).Assembly).GetType("Microsoft.Xml.Serialization.GeneratedAssembly.XmlSerializationReaderVimPortType");
                if (type == (System.Type)null)
                    return (XmlSerializer)null;
                return (XmlSerializer)FaultUtility.FaultXmlSerializer.Create(type);
            }

            internal class FaultXmlSerializer : XmlSerializer
            {
                private static MethodInfo _readMethodFault;
                private static ConstructorInfo _constructor;

                protected FaultXmlSerializer()
                {
                }

                public static FaultUtility.FaultXmlSerializer Create(System.Type xmlSerializationReaderVimPortType)
                {
                    if (FaultUtility.FaultXmlSerializer._readMethodFault == (MethodInfo)null)
                    {
                        xmlSerializationReaderVimPortType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
                        FaultUtility.FaultXmlSerializer._readMethodFault = Array.Find<MethodInfo>(xmlSerializationReaderVimPortType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic), (Predicate<MethodInfo>)(m =>
                        {
                            if (m.Name.StartsWith("Read"))
                                return m.Name.EndsWith("_MethodFault");
                            return false;
                        }));
                        FaultUtility.FaultXmlSerializer._constructor = xmlSerializationReaderVimPortType.GetConstructor(new System.Type[0]);
                        if (FaultUtility.FaultXmlSerializer._readMethodFault == (MethodInfo)null || FaultUtility.FaultXmlSerializer._constructor == (ConstructorInfo)null)
                            return (FaultUtility.FaultXmlSerializer)null;
                    }
                    return new FaultUtility.FaultXmlSerializer();
                }

                protected override XmlSerializationReader CreateReader()
                {
                    return (XmlSerializationReader)FaultUtility.FaultXmlSerializer._constructor.Invoke(new object[0]);
                }

                public override bool CanDeserialize(XmlReader xmlReader)
                {
                    return true;
                }

                protected override object Deserialize(XmlSerializationReader reader)
                {
                    return (object)this.ReadMethodFault(reader, false, true);
                }

                protected VimApi_65.MethodFault ReadMethodFault(XmlSerializationReader reader, bool isNullable, bool checkType)
                {
                    return (VimApi_65.MethodFault)FaultUtility.FaultXmlSerializer._readMethodFault.Invoke((object)reader, new object[2]
                    {
          (object) isNullable,
          (object) checkType
                    });
                }
            }
        }
    }
