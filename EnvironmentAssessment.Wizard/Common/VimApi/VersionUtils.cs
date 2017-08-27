using System;

namespace EnvironmentAssessment.Common.VimApi
{
	internal class VersionUtils
	{
		/* private static readonly string VIMSERVICE_VERSIONSXML_URL = "sdk/vimServiceVersions.xml";
		private static readonly string VIMSERVICE_WSDL_URL = "sdk/vimService?wsdl";
		internal static string GetVIServerTNS(string serviceUrl)
		{
			return "urn:vim25";
		}
		internal static Dictionary<string, string> GetVIServerSupportedVersions(string serviceUrl)
		{
			if (serviceUrl == null)
			{
				throw new ArgumentNullException(Resources.InvalidServiceUrl);
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			Uri uri = new Uri(serviceUrl);
			Uri uri2 = new Uri(new Uri(uri.GetLeftPart(UriPartial.Authority)), VersionUtils.VIMSERVICE_VERSIONSXML_URL);
			XmlTextReader xmlTextReader = new XmlTextReader(uri2.ToString());
			xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
			try
			{
				while (xmlTextReader.ReadToFollowing("namespace"))
				{
					xmlTextReader.ReadStartElement("namespace");
					xmlTextReader.ReadStartElement("name");
					string key = xmlTextReader.ReadString();
					xmlTextReader.ReadEndElement();
					xmlTextReader.ReadStartElement("version");
					string value = xmlTextReader.ReadString();
					xmlTextReader.ReadEndElement();
					dictionary.Add(key, value);
				}
				xmlTextReader.Close();
			}
			catch (WebException)
			{
			}
			return dictionary;
		}
		internal static VimVersion GetVIServerVersion(string serviceUrl)
		{
			Dictionary<string, string> vIServerSupportedVersions = VersionUtils.GetVIServerSupportedVersions(serviceUrl);
			string vIServerTNS = VersionUtils.GetVIServerTNS(serviceUrl);
			VimVersion result;
			if (vIServerSupportedVersions.ContainsKey(vIServerTNS))
			{
				result = VersionUtils.GetVersionFromApi(vIServerSupportedVersions[vIServerTNS]);
			}
			else
			{
				result = VersionUtils.GetVersionFromTNS(vIServerTNS);
			}
			return result;
		}
		internal static string GetVimServiceTNS(VimVersion ver)
		{
			return "urn:vim25";
		}
		internal static Type GetVimServiceType(VimVersion ver)
		{
			return typeof(VimService);
		}
		internal static Type GetVimType(string typeName, VimVersion ver)
		{
			Assembly assembly = typeof(VimApi_65.ManagedObjectReference).Assembly;
			typeName = "VimApi_65." + typeName;
			return assembly.GetType(typeName, false);
		}
		internal static VimVersion GetVersionFromTNS(string tns)
		{
			if (tns.Equals("urn:vim25"))
			{
				return VimVersion.Vim25;
			}
			if (tns.Equals("urn:vim25"))
			{
				return VimVersion.Vim4;
			}
			if (tns.Equals("urn:vim25"))
			{
				return VimVersion.Vim41;
			}
			if (tns.Equals("urn:vim25"))
			{
				return VimVersion.Vim50;
			}
			if (tns.Equals("urn:vim25"))
			{
				return VimVersion.Vim51;
			}
            if (tns.Equals("urn:vim25"))
            {
                return VimVersion.Vim55;
            }
			return VimVersion.Vim60;
		} */
		
		internal static VimVersion GetVIServerVersion(ServiceContent content)
		{
			string apiVersion;
			if (content != null && content.About != null && content.About.ApiVersion != null)
			{
				apiVersion = (content.About.ApiVersion ?? string.Empty);
			}
			else
			{
				apiVersion = string.Empty;
			}
			return VersionUtils.GetVersionFromApi(apiVersion);
		}
		
		internal static VimVersion GetVersionFromApi(string apiVersion)
		{
			if (apiVersion.StartsWith("2.5"))
			{
				return VimVersion.Vim25;
			}
			if (apiVersion.StartsWith("4.0"))
			{
				return VimVersion.Vim4;
			}
			if (apiVersion.StartsWith("4.1"))
			{
				return VimVersion.Vim41;
			}
			if (apiVersion.StartsWith("5.0"))
			{
				return VimVersion.Vim50;
			}
			if (apiVersion.StartsWith("5.1"))
			{
				return VimVersion.Vim51;
			}
            if (apiVersion.StartsWith("5.5"))
            {
                return VimVersion.Vim55;
            }
			if (apiVersion.StartsWith("6.0"))
			{
				return VimVersion.Vim60;
			}
			return VimVersion.Vim65;
		}
	
		public static void RequiresVersion(IVimClient _client, VimVersion _version)
		{
			if (_client.Version < _version) 
			{
				throw new NotSupportedException(string.Format(Resources.MethodNotSupported, _client.ServiceContent.About.ApiVersion));
			}
		}
	}
}
