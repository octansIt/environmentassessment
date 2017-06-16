using System;
using System.Web.Services.Protocols;
using VimApi_60;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostCacheConfigurationManager : ViewBase
	{
		protected HostCacheConfigurationInfo[] _cacheConfigurationInfo;
		public HostCacheConfigurationInfo[] CacheConfigurationInfo
		{
			get
			{
				return this._cacheConfigurationInfo;
			}
		}
		public HostCacheConfigurationManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ConfigureHostCache_Task(HostCacheConfigurationSpec spec)
		{
			ManagedObjectReference result;
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				result = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ConfigureHostCache_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostCacheConfigurationSpec)VIConvert.ToWsdlType(spec)));
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
			return result;
		}
		public void ConfigureHostCache(HostCacheConfigurationSpec spec)
		{
			try
			{
				if (this.Client.Version == VimVersion.Vim25)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim4)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				if (this.Client.Version == VimVersion.Vim41)
				{
					throw new NotSupportedException(string.Format(Resources.MethodNotSupported, this.Client.ServiceContent.About.ApiVersion));
				}
				ManagedObjectReference taskReference = (ManagedObjectReference)VIConvert.ToVim(((VimService)this.Client.VimService).ConfigureHostCache_Task((VimApi_60.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef), (VimApi_60.HostCacheConfigurationSpec)VIConvert.ToWsdlType(spec)));
				this.Client.WaitForTask(taskReference);
			}
			catch (SoapException ex)
			{
				throw new VimException(ex.Message, this.Client.GetVIServerFault(ex), ex);
			}
		}
	}
}
