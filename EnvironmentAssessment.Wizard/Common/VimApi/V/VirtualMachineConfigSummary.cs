namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineConfigSummary : DynamicData
	{
		protected string _name;
		protected bool _template;
		protected string _vmPathName;
		protected int? _memorySizeMB;
		protected int? _cpuReservation;
		protected int? _memoryReservation;
		protected int? _numCpu;
		protected int? _numEthernetCards;
		protected int? _numVirtualDisks;
		protected string _uuid;
		protected string _instanceUuid;
		protected string _guestId;
		protected string _guestFullName;
		protected string _annotation;
		protected VAppProductInfo _product;
		protected bool? _installBootRequired;
		protected FaultToleranceConfigInfo _ftInfo;
		protected ManagedByInfo _managedBy;
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
		public bool Template
		{
			get
			{
				return this._template;
			}
			set
			{
				this._template = value;
			}
		}
		public string VmPathName
		{
			get
			{
				return this._vmPathName;
			}
			set
			{
				this._vmPathName = value;
			}
		}
		public int? MemorySizeMB
		{
			get
			{
				return this._memorySizeMB;
			}
			set
			{
				this._memorySizeMB = value;
			}
		}
		public int? CpuReservation
		{
			get
			{
				return this._cpuReservation;
			}
			set
			{
				this._cpuReservation = value;
			}
		}
		public int? MemoryReservation
		{
			get
			{
				return this._memoryReservation;
			}
			set
			{
				this._memoryReservation = value;
			}
		}
		public int? NumCpu
		{
			get
			{
				return this._numCpu;
			}
			set
			{
				this._numCpu = value;
			}
		}
		public int? NumEthernetCards
		{
			get
			{
				return this._numEthernetCards;
			}
			set
			{
				this._numEthernetCards = value;
			}
		}
		public int? NumVirtualDisks
		{
			get
			{
				return this._numVirtualDisks;
			}
			set
			{
				this._numVirtualDisks = value;
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
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
		public string GuestId
		{
			get
			{
				return this._guestId;
			}
			set
			{
				this._guestId = value;
			}
		}
		public string GuestFullName
		{
			get
			{
				return this._guestFullName;
			}
			set
			{
				this._guestFullName = value;
			}
		}
		public string Annotation
		{
			get
			{
				return this._annotation;
			}
			set
			{
				this._annotation = value;
			}
		}
		public VAppProductInfo Product
		{
			get
			{
				return this._product;
			}
			set
			{
				this._product = value;
			}
		}
		public bool? InstallBootRequired
		{
			get
			{
				return this._installBootRequired;
			}
			set
			{
				this._installBootRequired = value;
			}
		}
		public FaultToleranceConfigInfo FtInfo
		{
			get
			{
				return this._ftInfo;
			}
			set
			{
				this._ftInfo = value;
			}
		}
		public ManagedByInfo ManagedBy
		{
			get
			{
				return this._managedBy;
			}
			set
			{
				this._managedBy = value;
			}
		}
	}
}
