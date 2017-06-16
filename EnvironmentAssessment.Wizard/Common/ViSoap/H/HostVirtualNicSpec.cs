namespace EnvironmentAssessment.Common.VISoap
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
	}
}
