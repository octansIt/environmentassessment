namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineConfigOptionDescriptor : DynamicData
	{
		protected string _key;
		protected string _description;
		protected ManagedObjectReference[] _host;
		protected bool _createSupported;
		protected bool _defaultConfigOption;
		protected bool _runSupported;
		protected bool _upgradeSupported;
		protected VirtualMachineConfigOptionDescriptor_LinkedView _linkedView;
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
		public bool CreateSupported
		{
			get
			{
				return this._createSupported;
			}
			set
			{
				this._createSupported = value;
			}
		}
		public bool DefaultConfigOption
		{
			get
			{
				return this._defaultConfigOption;
			}
			set
			{
				this._defaultConfigOption = value;
			}
		}
		public bool RunSupported
		{
			get
			{
				return this._runSupported;
			}
			set
			{
				this._runSupported = value;
			}
		}
		public bool UpgradeSupported
		{
			get
			{
				return this._upgradeSupported;
			}
			set
			{
				this._upgradeSupported = value;
			}
		}
		public VirtualMachineConfigOptionDescriptor_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
