namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicSpec : DynamicData
	{
		protected HostIpConfig _ip;
		protected string _mac;
		protected DistributedVirtualSwitchPortConnection _distributedVirtualPort;
		protected string _portgroup;
		protected int? _mtu;
		protected bool? _tsoEnabled;
		protected string _netStackInstanceKey;
		protected HostVirtualNicOpaqueNetworkSpec _opaqueNetwork;
		protected string _externalId;
		protected string _pinnedPnic;
		protected HostVirtualNicIpRouteSpec _ipRouteSpec;
		public HostIpConfig Ip
		{
			get
			{
				return this._ip;
			}
			set
			{
				this._ip = value;
			}
		}
		public string Mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				this._mac = value;
			}
		}
		public DistributedVirtualSwitchPortConnection DistributedVirtualPort
		{
			get
			{
				return this._distributedVirtualPort;
			}
			set
			{
				this._distributedVirtualPort = value;
			}
		}
		public string Portgroup
		{
			get
			{
				return this._portgroup;
			}
			set
			{
				this._portgroup = value;
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
		public bool? TsoEnabled
		{
			get
			{
				return this._tsoEnabled;
			}
			set
			{
				this._tsoEnabled = value;
			}
		}
		public string NetStackInstanceKey
		{
			get
			{
				return this._netStackInstanceKey;
			}
			set
			{
				this._netStackInstanceKey = value;
			}
		}
		public HostVirtualNicOpaqueNetworkSpec OpaqueNetwork
		{
			get
			{
				return this._opaqueNetwork;
			}
			set
			{
				this._opaqueNetwork = value;
			}
		}
		public string ExternalId
		{
			get
			{
				return this._externalId;
			}
			set
			{
				this._externalId = value;
			}
		}
		public string PinnedPnic
		{
			get
			{
				return this._pinnedPnic;
			}
			set
			{
				this._pinnedPnic = value;
			}
		}
		public HostVirtualNicIpRouteSpec IpRouteSpec
		{
			get
			{
				return this._ipRouteSpec;
			}
			set
			{
				this._ipRouteSpec = value;
			}
		}
	}
}
