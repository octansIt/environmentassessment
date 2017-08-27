namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineCloneSpec : DynamicData
	{
		protected VirtualMachineRelocateSpec _location;
		protected bool _template;
		protected VirtualMachineConfigSpec _config;
		protected CustomizationSpec _customization;
		protected bool _powerOn;
		protected ManagedObjectReference _snapshot;
		protected bool? _memory;
		protected VirtualMachineCloneSpec_LinkedView _linkedView;
		public VirtualMachineRelocateSpec Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
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
		public VirtualMachineConfigSpec Config
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
		public CustomizationSpec Customization
		{
			get
			{
				return this._customization;
			}
			set
			{
				this._customization = value;
			}
		}
		public bool PowerOn
		{
			get
			{
				return this._powerOn;
			}
			set
			{
				this._powerOn = value;
			}
		}
		public ManagedObjectReference Snapshot
		{
			get
			{
				return this._snapshot;
			}
			set
			{
				this._snapshot = value;
			}
		}
		public bool? Memory
		{
			get
			{
				return this._memory;
			}
			set
			{
				this._memory = value;
			}
		}
		public VirtualMachineCloneSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
