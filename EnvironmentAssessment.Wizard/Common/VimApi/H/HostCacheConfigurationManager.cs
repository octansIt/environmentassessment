using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
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
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ConfigureHostCacheRequestType configureHostCacheRequestType = new ConfigureHostCacheRequestType();
				configureHostCacheRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureHostCacheRequestType.spec = (VimApi_65.HostCacheConfigurationSpec)VIConvert.ToWsdlType(spec);
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ConfigureHostCache_Task(new ConfigureHostCache_TaskRequest(configureHostCacheRequestType)).ConfigureHostCache_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void ConfigureHostCache(HostCacheConfigurationSpec spec)
		{
			try
			{
				VersionUtils.RequiresVersion(this.Client, VimVersion.Vim50);
				ManagedObjectReference taskReference = this.ConfigureHostCache_Task(spec);
				this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
	}
}
