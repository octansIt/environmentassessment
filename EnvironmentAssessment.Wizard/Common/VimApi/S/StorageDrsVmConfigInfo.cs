namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsVmConfigInfo : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected bool? _enabled;
		protected string _behavior;
		protected bool? _intraVmAffinity;
		protected VirtualDiskAntiAffinityRuleSpec _intraVmAntiAffinity;
		protected StorageDrsVmConfigInfo_LinkedView _linkedView;
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
		public bool? Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public string Behavior
		{
			get
			{
				return this._behavior;
			}
			set
			{
				this._behavior = value;
			}
		}
		public bool? IntraVmAffinity
		{
			get
			{
				return this._intraVmAffinity;
			}
			set
			{
				this._intraVmAffinity = value;
			}
		}
		public VirtualDiskAntiAffinityRuleSpec IntraVmAntiAffinity
		{
			get
			{
				return this._intraVmAntiAffinity;
			}
			set
			{
				this._intraVmAntiAffinity = value;
			}
		}
		public StorageDrsVmConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
