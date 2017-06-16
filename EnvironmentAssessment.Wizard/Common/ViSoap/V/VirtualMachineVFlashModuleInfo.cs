namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineVFlashModuleInfo : VirtualMachineTargetInfo
	{
		protected HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption _vFlashModule;
		public HostVFlashManagerVFlashCacheConfigInfoVFlashModuleConfigOption VFlashModule
		{
			get
			{
				return this._vFlashModule;
			}
			set
			{
				this._vFlashModule = value;
			}
		}
	}
}
