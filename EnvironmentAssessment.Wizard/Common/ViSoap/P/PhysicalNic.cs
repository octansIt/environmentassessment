namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNic : DynamicData
	{
		protected string _key;
		protected string _device;
		protected string _pci;
		protected string _driver;
		protected PhysicalNicLinkInfo _linkSpeed;
		protected PhysicalNicLinkInfo[] _validLinkSpecification;
		protected PhysicalNicSpec _spec;
		protected bool _wakeOnLanSupported;
		protected string _mac;
		protected FcoeConfig _fcoeConfiguration;
		protected bool? _vmDirectPathGen2Supported;
		protected string _vmDirectPathGen2SupportedMode;
		protected bool? _resourcePoolSchedulerAllowed;
		protected string[] _resourcePoolSchedulerDisallowedReason;
		protected bool? _autoNegotiateSupported;
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
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string Pci
		{
			get
			{
				return this._pci;
			}
			set
			{
				this._pci = value;
			}
		}
		public string Driver
		{
			get
			{
				return this._driver;
			}
			set
			{
				this._driver = value;
			}
		}
		public PhysicalNicLinkInfo LinkSpeed
		{
			get
			{
				return this._linkSpeed;
			}
			set
			{
				this._linkSpeed = value;
			}
		}
		public PhysicalNicLinkInfo[] ValidLinkSpecification
		{
			get
			{
				return this._validLinkSpecification;
			}
			set
			{
				this._validLinkSpecification = value;
			}
		}
		public PhysicalNicSpec Spec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}
		public bool WakeOnLanSupported
		{
			get
			{
				return this._wakeOnLanSupported;
			}
			set
			{
				this._wakeOnLanSupported = value;
			}
		}
		public string Mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				this._mac = value;
			}
		}
		public FcoeConfig FcoeConfiguration
		{
			get
			{
				return this._fcoeConfiguration;
			}
			set
			{
				this._fcoeConfiguration = value;
			}
		}
		public bool? VmDirectPathGen2Supported
		{
			get
			{
				return this._vmDirectPathGen2Supported;
			}
			set
			{
				this._vmDirectPathGen2Supported = value;
			}
		}
		public string VmDirectPathGen2SupportedMode
		{
			get
			{
				return this._vmDirectPathGen2SupportedMode;
			}
			set
			{
				this._vmDirectPathGen2SupportedMode = value;
			}
		}
		public bool? ResourcePoolSchedulerAllowed
		{
			get
			{
				return this._resourcePoolSchedulerAllowed;
			}
			set
			{
				this._resourcePoolSchedulerAllowed = value;
			}
		}
		public string[] ResourcePoolSchedulerDisallowedReason
		{
			get
			{
				return this._resourcePoolSchedulerDisallowedReason;
			}
			set
			{
				this._resourcePoolSchedulerDisallowedReason = value;
			}
		}
		public bool? AutoNegotiateSupported
		{
			get
			{
				return this._autoNegotiateSupported;
			}
			set
			{
				this._autoNegotiateSupported = value;
			}
		}
	}
}
