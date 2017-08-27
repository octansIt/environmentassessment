using System.ServiceModel;
using VimApi_65;
namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVFlashManager : ViewBase
	{
		protected HostVFlashManagerVFlashConfigInfo _vFlashConfigInfo;
		public HostVFlashManagerVFlashConfigInfo VFlashConfigInfo
		{
			get
			{
				return this._vFlashConfigInfo;
			}
		}
		public HostVFlashManager(IVimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
		public ManagedObjectReference ConfigureVFlashResourceEx_Task(string[] devicePath)
		{
			ManagedObjectReference result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ConfigureVFlashResourceExRequestType configureVFlashResourceExRequestType = new ConfigureVFlashResourceExRequestType();
				configureVFlashResourceExRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				configureVFlashResourceExRequestType.devicePath = devicePath;
				result = (ManagedObjectReference)VIConvert.ToVim(this.VimServiceProxy.ConfigureVFlashResourceEx_Task(new ConfigureVFlashResourceEx_TaskRequest(configureVFlashResourceExRequestType)).ConfigureVFlashResourceEx_TaskResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public HostVFlashResourceConfigurationResult ConfigureVFlashResourceEx(string[] devicePath)
		{
			HostVFlashResourceConfigurationResult result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				ManagedObjectReference taskReference = this.ConfigureVFlashResourceEx_Task(devicePath);
				result = (HostVFlashResourceConfigurationResult)this.Client.WaitForTask(taskReference);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
		public void HostConfigureVFlashResource(HostVFlashManagerVFlashResourceConfigSpec spec)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				HostConfigureVFlashResourceRequestType hostConfigureVFlashResourceRequestType = new HostConfigureVFlashResourceRequestType();
				hostConfigureVFlashResourceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostConfigureVFlashResourceRequestType.spec = (VimApi_65.HostVFlashManagerVFlashResourceConfigSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.HostConfigureVFlashResource(new HostConfigureVFlashResourceRequest(hostConfigureVFlashResourceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void HostRemoveVFlashResource()
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				HostRemoveVFlashResourceRequestType hostRemoveVFlashResourceRequestType = new HostRemoveVFlashResourceRequestType();
				hostRemoveVFlashResourceRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				this.VimServiceProxy.HostRemoveVFlashResource(new HostRemoveVFlashResourceRequest(hostRemoveVFlashResourceRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public void HostConfigVFlashCache(HostVFlashManagerVFlashCacheConfigSpec spec)
		{
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				HostConfigVFlashCacheRequestType hostConfigVFlashCacheRequestType = new HostConfigVFlashCacheRequestType();
				hostConfigVFlashCacheRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostConfigVFlashCacheRequestType.spec = (VimApi_65.HostVFlashManagerVFlashCacheConfigSpec)VIConvert.ToWsdlType(spec);
				this.VimServiceProxy.HostConfigVFlashCache(new HostConfigVFlashCacheRequest(hostConfigVFlashCacheRequestType));
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
		}
		public VirtualDiskVFlashCacheConfigInfo HostGetVFlashModuleDefaultConfig(string vFlashModule)
		{
			VirtualDiskVFlashCacheConfigInfo result;
			try
			{
                VersionUtils.RequiresVersion(this.Client, VimVersion.Vim55);
				HostGetVFlashModuleDefaultConfigRequestType hostGetVFlashModuleDefaultConfigRequestType = new HostGetVFlashModuleDefaultConfigRequestType();
				hostGetVFlashModuleDefaultConfigRequestType._this = (VimApi_65.ManagedObjectReference)VIConvert.ToWsdlType(this.MoRef);
				hostGetVFlashModuleDefaultConfigRequestType.vFlashModule = vFlashModule;
				result = (VirtualDiskVFlashCacheConfigInfo)VIConvert.ToVim(this.VimServiceProxy.HostGetVFlashModuleDefaultConfig(new HostGetVFlashModuleDefaultConfigRequest(hostGetVFlashModuleDefaultConfigRequestType)).HostGetVFlashModuleDefaultConfigResponse.returnval);
			}
			catch (FaultException ex)
			{
				throw FaultUtility.HandleFault(ex);
			}
			return result;
		}
	}
}
