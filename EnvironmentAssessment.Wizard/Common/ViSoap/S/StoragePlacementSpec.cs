namespace EnvironmentAssessment.Common.VISoap
{
    public class StoragePlacementSpec : DynamicData
	{
		protected string _type;
		protected VirtualMachineMovePriority? _priority;
		protected ManagedObjectReference _vm;
		protected StorageDrsPodSelectionSpec _podSelectionSpec;
		protected VirtualMachineCloneSpec _cloneSpec;
		protected string _cloneName;
		protected VirtualMachineConfigSpec _configSpec;
		protected VirtualMachineRelocateSpec _relocateSpec;
		protected ManagedObjectReference _resourcePool;
		protected ManagedObjectReference _host;
		protected ManagedObjectReference _folder;
		protected bool? _disallowPrerequisiteMoves;
		protected int? _resourceLeaseDurationSec;
		protected StoragePlacementSpec_LinkedView _linkedView;
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public VirtualMachineMovePriority? Priority
		{
			get
			{
				return this._priority;
			}
			set
			{
				this._priority = value;
			}
		}
		public ManagedObjectReference Vm
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
		public StorageDrsPodSelectionSpec PodSelectionSpec
		{
			get
			{
				return this._podSelectionSpec;
			}
			set
			{
				this._podSelectionSpec = value;
			}
		}
		public VirtualMachineCloneSpec CloneSpec
		{
			get
			{
				return this._cloneSpec;
			}
			set
			{
				this._cloneSpec = value;
			}
		}
		public string CloneName
		{
			get
			{
				return this._cloneName;
			}
			set
			{
				this._cloneName = value;
			}
		}
		public VirtualMachineConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
		public VirtualMachineRelocateSpec RelocateSpec
		{
			get
			{
				return this._relocateSpec;
			}
			set
			{
				this._relocateSpec = value;
			}
		}
		public ManagedObjectReference ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
			set
			{
				this._resourcePool = value;
			}
		}
		public ManagedObjectReference Host
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
		public ManagedObjectReference Folder
		{
			get
			{
				return this._folder;
			}
			set
			{
				this._folder = value;
			}
		}
		public bool? DisallowPrerequisiteMoves
		{
			get
			{
				return this._disallowPrerequisiteMoves;
			}
			set
			{
				this._disallowPrerequisiteMoves = value;
			}
		}
		public int? ResourceLeaseDurationSec
		{
			get
			{
				return this._resourceLeaseDurationSec;
			}
			set
			{
				this._resourceLeaseDurationSec = value;
			}
		}
		public StoragePlacementSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
