namespace EnvironmentAssessment.Common.VISoap
{
    public class DeviceUnsupportedForVmVersion : InvalidDeviceSpec
	{
		protected string _currentVersion;
		protected string _expectedVersion;
		public string CurrentVersion
		{
			get
			{
				return this._currentVersion;
			}
			set
			{
				this._currentVersion = value;
			}
		}
		public string ExpectedVersion
		{
			get
			{
				return this._expectedVersion;
			}
			set
			{
				this._expectedVersion = value;
			}
		}
	}
}
