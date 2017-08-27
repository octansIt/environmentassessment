namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementSpec : DynamicData
	{
		protected VirtualMachineMovePriority? _priority;
		protected ManagedObjectReference _vm;
		protected VirtualMachineConfigSpec _configSpec;
		protected VirtualMachineRelocateSpec _relocateSpec;
		protected ManagedObjectReference[] _hosts;
		protected ManagedObjectReference[] _datastores;
		protected ManagedObjectReference[] _storagePods;
		protected bool? _disallowPrerequisiteMoves;
		protected ClusterRuleInfo[] _rules;
		protected string _key;
		protected string _placementType;
		protected VirtualMachineCloneSpec _cloneSpec;
		protected string _cloneName;
		protected PlacementSpec_LinkedView _linkedView;
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
		public ManagedObjectReference[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
		public ManagedObjectReference[] Datastores
		{
			get
			{
				return this._datastores;
			}
			set
			{
				this._datastores = value;
			}
		}
		public ManagedObjectReference[] StoragePods
		{
			get
			{
				return this._storagePods;
			}
			set
			{
				this._storagePods = value;
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
		public ClusterRuleInfo[] Rules
		{
			get
			{
				return this._rules;
			}
			set
			{
				this._rules = value;
			}
		}
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string PlacementType
		{
			get
			{
				return this._placementType;
			}
			set
			{
				this._placementType = value;
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
		public PlacementSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
