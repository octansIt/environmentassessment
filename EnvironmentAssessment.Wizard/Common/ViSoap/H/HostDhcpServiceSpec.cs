namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDhcpServiceSpec : DynamicData
	{
		protected string _virtualSwitch;
		protected int _defaultLeaseDuration;
		protected string _leaseBeginIp;
		protected string _leaseEndIp;
		protected int _maxLeaseDuration;
		protected bool _unlimitedLease;
		protected string _ipSubnetAddr;
		protected string _ipSubnetMask;
		public string VirtualSwitch
		{
			get
			{
				return this._virtualSwitch;
			}
			set
			{
				this._virtualSwitch = value;
			}
		}
		public int DefaultLeaseDuration
		{
			get
			{
				return this._defaultLeaseDuration;
			}
			set
			{
				this._defaultLeaseDuration = value;
			}
		}
		public string LeaseBeginIp
		{
			get
			{
				return this._leaseBeginIp;
			}
			set
			{
				this._leaseBeginIp = value;
			}
		}
		public string LeaseEndIp
		{
			get
			{
				return this._leaseEndIp;
			}
			set
			{
				this._leaseEndIp = value;
			}
		}
		public int MaxLeaseDuration
		{
			get
			{
				return this._maxLeaseDuration;
			}
			set
			{
				this._maxLeaseDuration = value;
			}
		}
		public bool UnlimitedLease
		{
			get
			{
				return this._unlimitedLease;
			}
			set
			{
				this._unlimitedLease = value;
			}
		}
		public string IpSubnetAddr
		{
			get
			{
				return this._ipSubnetAddr;
			}
			set
			{
				this._ipSubnetAddr = value;
			}
		}
		public string IpSubnetMask
		{
			get
			{
				return this._ipSubnetMask;
			}
			set
			{
				this._ipSubnetMask = value;
			}
		}
	}
}
