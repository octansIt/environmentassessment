namespace EnvironmentAssessment.Common.VISoap
{
    public class DVPortStatus : DynamicData
	{
		protected bool _linkUp;
		protected bool _blocked;
		protected NumericRange[] _vlanIds;
		protected bool? _trunkingMode;
		protected int? _mtu;
		protected string _linkPeer;
		protected string _macAddress;
		protected string _statusDetail;
		protected bool? _vmDirectPathGen2Active;
		protected string[] _vmDirectPathGen2InactiveReasonNetwork;
		protected string[] _vmDirectPathGen2InactiveReasonOther;
		protected string _vmDirectPathGen2InactiveReasonExtended;
		public bool LinkUp
		{
			get
			{
				return this._linkUp;
			}
			set
			{
				this._linkUp = value;
			}
		}
		public bool Blocked
		{
			get
			{
				return this._blocked;
			}
			set
			{
				this._blocked = value;
			}
		}
		public NumericRange[] VlanIds
		{
			get
			{
				return this._vlanIds;
			}
			set
			{
				this._vlanIds = value;
			}
		}
		public bool? TrunkingMode
		{
			get
			{
				return this._trunkingMode;
			}
			set
			{
				this._trunkingMode = value;
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
		public string LinkPeer
		{
			get
			{
				return this._linkPeer;
			}
			set
			{
				this._linkPeer = value;
			}
		}
		public string MacAddress
		{
			get
			{
				return this._macAddress;
			}
			set
			{
				this._macAddress = value;
			}
		}
		public string StatusDetail
		{
			get
			{
				return this._statusDetail;
			}
			set
			{
				this._statusDetail = value;
			}
		}
		public bool? VmDirectPathGen2Active
		{
			get
			{
				return this._vmDirectPathGen2Active;
			}
			set
			{
				this._vmDirectPathGen2Active = value;
			}
		}
		public string[] VmDirectPathGen2InactiveReasonNetwork
		{
			get
			{
				return this._vmDirectPathGen2InactiveReasonNetwork;
			}
			set
			{
				this._vmDirectPathGen2InactiveReasonNetwork = value;
			}
		}
		public string[] VmDirectPathGen2InactiveReasonOther
		{
			get
			{
				return this._vmDirectPathGen2InactiveReasonOther;
			}
			set
			{
				this._vmDirectPathGen2InactiveReasonOther = value;
			}
		}
		public string VmDirectPathGen2InactiveReasonExtended
		{
			get
			{
				return this._vmDirectPathGen2InactiveReasonExtended;
			}
			set
			{
				this._vmDirectPathGen2InactiveReasonExtended = value;
			}
		}
	}
}
