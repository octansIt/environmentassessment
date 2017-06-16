namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSSummary : DynamicData
	{
		protected string _name;
		protected string _uuid;
		protected int _numPorts;
		protected DistributedVirtualSwitchProductSpec _productInfo;
		protected ManagedObjectReference[] _hostMember;
		protected ManagedObjectReference[] _vm;
		protected ManagedObjectReference[] _host;
		protected string[] _portgroupName;
		protected string _description;
		protected DVSContactInfo _contact;
		protected int? _numHosts;
		protected DVSSummary_LinkedView _linkedView;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
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
		public DistributedVirtualSwitchProductSpec ProductInfo
		{
			get
			{
				return this._productInfo;
			}
			set
			{
				this._productInfo = value;
			}
		}
		public ManagedObjectReference[] HostMember
		{
			get
			{
				return this._hostMember;
			}
			set
			{
				this._hostMember = value;
			}
		}
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public ManagedObjectReference[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public string[] PortgroupName
		{
			get
			{
				return this._portgroupName;
			}
			set
			{
				this._portgroupName = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public DVSContactInfo Contact
		{
			get
			{
				return this._contact;
			}
			set
			{
				this._contact = value;
			}
		}
		public int? NumHosts
		{
			get
			{
				return this._numHosts;
			}
			set
			{
				this._numHosts = value;
			}
		}
		public DVSSummary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
