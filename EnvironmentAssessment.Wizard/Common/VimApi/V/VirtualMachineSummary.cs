namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSummary : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected VirtualMachineRuntimeInfo _runtime;
		protected VirtualMachineGuestSummary _guest;
		protected VirtualMachineConfigSummary _config;
		protected VirtualMachineStorageSummary _storage;
		protected VirtualMachineQuickStats _quickStats;
		protected ManagedEntityStatus _overallStatus;
		protected CustomFieldValue[] _customValue;
		protected VirtualMachineSummary_LinkedView _linkedView;
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
		public VirtualMachineRuntimeInfo Runtime
		{
			get
			{
				return this._runtime;
			}
			set
			{
				this._runtime = value;
			}
		}
		public VirtualMachineGuestSummary Guest
		{
			get
			{
				return this._guest;
			}
			set
			{
				this._guest = value;
			}
		}
		public VirtualMachineConfigSummary Config
		{
			get
			{
				return this._config;
			}
			set
			{
				this._config = value;
			}
		}
		public VirtualMachineStorageSummary Storage
		{
			get
			{
				return this._storage;
			}
			set
			{
				this._storage = value;
			}
		}
		public VirtualMachineQuickStats QuickStats
		{
			get
			{
				return this._quickStats;
			}
			set
			{
				this._quickStats = value;
			}
		}
		public ManagedEntityStatus OverallStatus
		{
			get
			{
				return this._overallStatus;
			}
			set
			{
				this._overallStatus = value;
			}
		}
		public CustomFieldValue[] CustomValue
		{
			get
			{
				return this._customValue;
			}
			set
			{
				this._customValue = value;
			}
		}
		public VirtualMachineSummary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
