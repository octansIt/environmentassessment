namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceOption : DynamicData
	{
		protected string _type;
		protected VirtualDeviceConnectOption _connectOption;
		protected VirtualDeviceBusSlotOption _busSlotOption;
		protected string _controllerType;
		protected BoolOption _autoAssignController;
		protected VirtualDeviceBackingOption[] _backingOption;
		protected int? _defaultBackingOptionIndex;
		protected string[] _licensingLimit;
		protected bool _deprecated;
		protected bool _plugAndPlay;
		protected bool _hotRemoveSupported;
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
		public VirtualDeviceConnectOption ConnectOption
		{
			get
			{
				return this._connectOption;
			}
			set
			{
				this._connectOption = value;
			}
		}
		public VirtualDeviceBusSlotOption BusSlotOption
		{
			get
			{
				return this._busSlotOption;
			}
			set
			{
				this._busSlotOption = value;
			}
		}
		public string ControllerType
		{
			get
			{
				return this._controllerType;
			}
			set
			{
				this._controllerType = value;
			}
		}
		public BoolOption AutoAssignController
		{
			get
			{
				return this._autoAssignController;
			}
			set
			{
				this._autoAssignController = value;
			}
		}
		public VirtualDeviceBackingOption[] BackingOption
		{
			get
			{
				return this._backingOption;
			}
			set
			{
				this._backingOption = value;
			}
		}
		public int? DefaultBackingOptionIndex
		{
			get
			{
				return this._defaultBackingOptionIndex;
			}
			set
			{
				this._defaultBackingOptionIndex = value;
			}
		}
		public string[] LicensingLimit
		{
			get
			{
				return this._licensingLimit;
			}
			set
			{
				this._licensingLimit = value;
			}
		}
		public bool Deprecated
		{
			get
			{
				return this._deprecated;
			}
			set
			{
				this._deprecated = value;
			}
		}
		public bool PlugAndPlay
		{
			get
			{
				return this._plugAndPlay;
			}
			set
			{
				this._plugAndPlay = value;
			}
		}
		public bool HotRemoveSupported
		{
			get
			{
				return this._hotRemoveSupported;
			}
			set
			{
				this._hotRemoveSupported = value;
			}
		}
	}
}
