namespace EnvironmentAssessment.Common.VISoap
{
    public class HostBootDeviceInfo : DynamicData
	{
		protected HostBootDevice[] _bootDevices;
		protected string _currentBootDeviceKey;
		public HostBootDevice[] BootDevices
		{
			get
			{
				return this._bootDevices;
			}
			set
			{
				this._bootDevices = value;
			}
		}
		public string CurrentBootDeviceKey
		{
			get
			{
				return this._currentBootDeviceKey;
			}
			set
			{
				this._currentBootDeviceKey = value;
			}
		}
	}
}
