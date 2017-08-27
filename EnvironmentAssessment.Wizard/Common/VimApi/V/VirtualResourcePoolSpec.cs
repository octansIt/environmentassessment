namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualResourcePoolSpec : DynamicData
	{
		protected string _vrpId;
		protected string _vrpName;
		protected string _description;
		protected VrpResourceAllocationInfo _cpuAllocation;
		protected VrpResourceAllocationInfo _memoryAllocation;
		protected ManagedObjectReference[] _rpList;
		protected ManagedObjectReference[] _hubList;
		protected bool? _rootVRP;
		protected bool? _staticVRP;
		protected long? _changeVersion;
		protected VirtualResourcePoolSpec_LinkedView _linkedView;
		public string VrpId
		{
			get
			{
				return this._vrpId;
			}
			set
			{
				this._vrpId = value;
			}
		}
		public string VrpName
		{
			get
			{
				return this._vrpName;
			}
			set
			{
				this._vrpName = value;
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
		public VrpResourceAllocationInfo CpuAllocation
		{
			get
			{
				return this._cpuAllocation;
			}
			set
			{
				this._cpuAllocation = value;
			}
		}
		public VrpResourceAllocationInfo MemoryAllocation
		{
			get
			{
				return this._memoryAllocation;
			}
			set
			{
				this._memoryAllocation = value;
			}
		}
		public ManagedObjectReference[] RpList
		{
			get
			{
				return this._rpList;
			}
			set
			{
				this._rpList = value;
			}
		}
		public ManagedObjectReference[] HubList
		{
			get
			{
				return this._hubList;
			}
			set
			{
				this._hubList = value;
			}
		}
		public bool? RootVRP
		{
			get
			{
				return this._rootVRP;
			}
			set
			{
				this._rootVRP = value;
			}
		}
		public bool? StaticVRP
		{
			get
			{
				return this._staticVRP;
			}
			set
			{
				this._staticVRP = value;
			}
		}
		public long? ChangeVersion
		{
			get
			{
				return this._changeVersion;
			}
			set
			{
				this._changeVersion = value;
			}
		}
		public VirtualResourcePoolSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
