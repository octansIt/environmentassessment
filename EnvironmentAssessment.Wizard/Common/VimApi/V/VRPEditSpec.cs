namespace EnvironmentAssessment.Common.VimApi
{
	public class VRPEditSpec : DynamicData
	{
		protected string _vrpId;
		protected string _description;
		protected VrpResourceAllocationInfo _cpuAllocation;
		protected VrpResourceAllocationInfo _memoryAllocation;
		protected ManagedObjectReference[] _addedHubs;
		protected ManagedObjectReference[] _removedHubs;
		protected long? _changeVersion;
		protected VRPEditSpec_LinkedView _linkedView;
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
		public ManagedObjectReference[] AddedHubs
		{
			get
			{
				return this._addedHubs;
			}
			set
			{
				this._addedHubs = value;
			}
		}
		public ManagedObjectReference[] RemovedHubs
		{
			get
			{
				return this._removedHubs;
			}
			set
			{
				this._removedHubs = value;
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
		public VRPEditSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
