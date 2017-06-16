namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVFlashResourceConfigurationResult : DynamicData
	{
		protected string[] _devicePath;
		protected HostVffsVolume _vffs;
		protected HostDiskConfigurationResult[] _diskConfigurationResult;
		public string[] DevicePath
		{
			get
			{
				return this._devicePath;
			}
			set
			{
				this._devicePath = value;
			}
		}
		public HostVffsVolume Vffs
		{
			get
			{
				return this._vffs;
			}
			set
			{
				this._vffs = value;
			}
		}
		public HostDiskConfigurationResult[] DiskConfigurationResult
		{
			get
			{
				return this._diskConfigurationResult;
			}
			set
			{
				this._diskConfigurationResult = value;
			}
		}
	}
}
