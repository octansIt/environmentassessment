namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVirtualSwitchAutoBridge : HostVirtualSwitchBridge
	{
		protected string[] _excludedNicDevice;
		public string[] ExcludedNicDevice
		{
			get
			{
				return this._excludedNicDevice;
			}
			set
			{
				this._excludedNicDevice = value;
			}
		}
	}
}
