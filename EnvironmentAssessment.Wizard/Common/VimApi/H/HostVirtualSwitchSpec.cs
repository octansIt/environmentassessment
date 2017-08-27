namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualSwitchSpec : DynamicData
	{
		protected int _numPorts;
		protected HostVirtualSwitchBridge _bridge;
		protected HostNetworkPolicy _policy;
		protected int? _mtu;
		public int NumPorts
		{
			get
			{
				return this._numPorts;
			}
			set
			{
				this._numPorts = value;
			}
		}
		public HostVirtualSwitchBridge Bridge
		{
			get
			{
				return this._bridge;
			}
			set
			{
				this._bridge = value;
			}
		}
		public HostNetworkPolicy Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
		public int? Mtu
		{
			get
			{
				return this._mtu;
			}
			set
			{
				this._mtu = value;
			}
		}
	}
}
