namespace EnvironmentAssessment.Common.VimApi
{
	public class PhysicalNicHintInfo : DynamicData
	{
		protected string _device;
		protected PhysicalNicIpHint[] _subnet;
		protected PhysicalNicNameHint[] _network;
		protected PhysicalNicCdpInfo _connectedSwitchPort;
		protected LinkLayerDiscoveryProtocolInfo _lldpInfo;
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public PhysicalNicIpHint[] Subnet
		{
			get
			{
				return this._subnet;
			}
			set
			{
				this._subnet = value;
			}
		}
		public PhysicalNicNameHint[] Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public PhysicalNicCdpInfo ConnectedSwitchPort
		{
			get
			{
				return this._connectedSwitchPort;
			}
			set
			{
				this._connectedSwitchPort = value;
			}
		}
		public LinkLayerDiscoveryProtocolInfo LldpInfo
		{
			get
			{
				return this._lldpInfo;
			}
			set
			{
				this._lldpInfo = value;
			}
		}
	}
}
