using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
namespace EnvironmentAssessment.Common.VimApi
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;
		private static CultureInfo resourceCulture;
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("VMware.Vim.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}
		internal static string InvalidObjectType
		{
			get
			{
				return Resources.ResourceManager.GetString("InvalidObjectType", Resources.resourceCulture);
			}
		}
		internal static string InvalidPropertiesParam
		{
			get
			{
				return Resources.ResourceManager.GetString("InvalidPropertiesParam", Resources.resourceCulture);
			}
		}
		internal static string InvalidServiceUrl
		{
			get
			{
				return Resources.ResourceManager.GetString("InvalidServiceUrl", Resources.resourceCulture);
			}
		}
		internal static string InvalidViewType
		{
			get
			{
				return Resources.ResourceManager.GetString("InvalidViewType", Resources.resourceCulture);
			}
		}
		internal static string InvalidViewTypeParam
		{
			get
			{
				return Resources.ResourceManager.GetString("InvalidViewTypeParam", Resources.resourceCulture);
			}
		}
		internal static string IvalidPropertyPath
		{
			get
			{
				return Resources.ResourceManager.GetString("IvalidPropertyPath", Resources.resourceCulture);
			}
		}
		internal static string MethodNotSupported
		{
			get
			{
				return Resources.ResourceManager.GetString("MethodNotSupported", Resources.resourceCulture);
			}
		}
		internal static string PropertyDoesntExist
		{
			get
			{
				return Resources.ResourceManager.GetString("PropertyDoesntExist", Resources.resourceCulture);
			}
		}
		internal static string ServiceContentNotInitialized
		{
			get
			{
				return Resources.ResourceManager.GetString("ServiceContentNotInitialized", Resources.resourceCulture);
			}
		}
		internal static string SessionCookieNotInitialized
		{
			get
			{
				return Resources.ResourceManager.GetString("SessionCookieNotInitialized", Resources.resourceCulture);
			}
		}
		internal static string SessionIdNotInitialized
		{
			get
			{
				return Resources.ResourceManager.GetString("SessionIdNotInitialized", Resources.resourceCulture);
			}
		}
		internal static string SpecifiedDataObjectType
		{
			get
			{
				return Resources.ResourceManager.GetString("SpecifiedDataObjectType", Resources.resourceCulture);
			}
		}
		internal static string VimWebServiceNotInitialized
		{
			get
			{
				return Resources.ResourceManager.GetString("VimWebServiceNotInitialized", Resources.resourceCulture);
			}
		}
		internal static string WrongPropertyType
		{
			get
			{
				return Resources.ResourceManager.GetString("WrongPropertyType", Resources.resourceCulture);
			}
		}
		internal static string WrongWildcardPosition
		{
			get
			{
				return Resources.ResourceManager.GetString("WrongWildcardPosition", Resources.resourceCulture);
			}
		}
		internal Resources()
		{
		}
	}
}
