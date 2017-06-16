namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVirtualSwitchBondBridge : HostVirtualSwitchBridge
	{
		protected string[] _nicDevice;
		protected HostVirtualSwitchBeaconConfig _beacon;
		protected LinkDiscoveryProtocolConfig _linkDiscoveryProtocolConfig;
		public string[] NicDevice
		{
			get
			{
				return this._nicDevice;
			}
			set
			{
				this._nicDevice = value;
			}
		}
		public HostVirtualSwitchBeaconConfig Beacon
		{
			get
			{
				return this._beacon;
			}
			set
			{
				this._beacon = value;
			}
		}
		public LinkDiscoveryProtocolConfig LinkDiscoveryProtocolConfig
		{
			get
			{
				return this._linkDiscoveryProtocolConfig;
			}
			set
			{
				this._linkDiscoveryProtocolConfig = value;
			}
		}
	}
}
