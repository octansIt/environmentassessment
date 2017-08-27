namespace EnvironmentAssessment.Common.VimApi
{
	public class HostConfigManager : DynamicData
	{
		protected ManagedObjectReference _cpuScheduler;
		protected ManagedObjectReference _datastoreSystem;
		protected ManagedObjectReference _memoryManager;
		protected ManagedObjectReference _storageSystem;
		protected ManagedObjectReference _networkSystem;
		protected ManagedObjectReference _vmotionSystem;
		protected ManagedObjectReference _virtualNicManager;
		protected ManagedObjectReference _serviceSystem;
		protected ManagedObjectReference _firewallSystem;
		protected ManagedObjectReference _advancedOption;
		protected ManagedObjectReference _diagnosticSystem;
		protected ManagedObjectReference _autoStartManager;
		protected ManagedObjectReference _snmpSystem;
		protected ManagedObjectReference _dateTimeSystem;
		protected ManagedObjectReference _patchManager;
		protected ManagedObjectReference _imageConfigManager;
		protected ManagedObjectReference _bootDeviceSystem;
		protected ManagedObjectReference _firmwareSystem;
		protected ManagedObjectReference _healthStatusSystem;
		protected ManagedObjectReference _pciPassthruSystem;
		protected ManagedObjectReference _licenseManager;
		protected ManagedObjectReference _kernelModuleSystem;
		protected ManagedObjectReference _authenticationManager;
		protected ManagedObjectReference _powerSystem;
		protected ManagedObjectReference _cacheConfigurationManager;
		protected ManagedObjectReference _esxAgentHostManager;
		protected ManagedObjectReference _iscsiManager;
		protected ManagedObjectReference _vFlashManager;
		protected ManagedObjectReference _vsanSystem;
		protected ManagedObjectReference _messageBusProxy;
		protected ManagedObjectReference _userDirectory;
		protected ManagedObjectReference _accountManager;
		protected ManagedObjectReference _hostAccessManager;
		protected ManagedObjectReference _graphicsManager;
		protected ManagedObjectReference _vsanInternalSystem;
		protected ManagedObjectReference _certificateManager;
		protected ManagedObjectReference _cryptoManager;
		protected HostConfigManager_LinkedView _linkedView;
		public ManagedObjectReference CpuScheduler
		{
			get
			{
				return this._cpuScheduler;
			}
			set
			{
				this._cpuScheduler = value;
			}
		}
		public ManagedObjectReference DatastoreSystem
		{
			get
			{
				return this._datastoreSystem;
			}
			set
			{
				this._datastoreSystem = value;
			}
		}
		public ManagedObjectReference MemoryManager
		{
			get
			{
				return this._memoryManager;
			}
			set
			{
				this._memoryManager = value;
			}
		}
		public ManagedObjectReference StorageSystem
		{
			get
			{
				return this._storageSystem;
			}
			set
			{
				this._storageSystem = value;
			}
		}
		public ManagedObjectReference NetworkSystem
		{
			get
			{
				return this._networkSystem;
			}
			set
			{
				this._networkSystem = value;
			}
		}
		public ManagedObjectReference VmotionSystem
		{
			get
			{
				return this._vmotionSystem;
			}
			set
			{
				this._vmotionSystem = value;
			}
		}
		public ManagedObjectReference VirtualNicManager
		{
			get
			{
				return this._virtualNicManager;
			}
			set
			{
				this._virtualNicManager = value;
			}
		}
		public ManagedObjectReference ServiceSystem
		{
			get
			{
				return this._serviceSystem;
			}
			set
			{
				this._serviceSystem = value;
			}
		}
		public ManagedObjectReference FirewallSystem
		{
			get
			{
				return this._firewallSystem;
			}
			set
			{
				this._firewallSystem = value;
			}
		}
		public ManagedObjectReference AdvancedOption
		{
			get
			{
				return this._advancedOption;
			}
			set
			{
				this._advancedOption = value;
			}
		}
		public ManagedObjectReference DiagnosticSystem
		{
			get
			{
				return this._diagnosticSystem;
			}
			set
			{
				this._diagnosticSystem = value;
			}
		}
		public ManagedObjectReference AutoStartManager
		{
			get
			{
				return this._autoStartManager;
			}
			set
			{
				this._autoStartManager = value;
			}
		}
		public ManagedObjectReference SnmpSystem
		{
			get
			{
				return this._snmpSystem;
			}
			set
			{
				this._snmpSystem = value;
			}
		}
		public ManagedObjectReference DateTimeSystem
		{
			get
			{
				return this._dateTimeSystem;
			}
			set
			{
				this._dateTimeSystem = value;
			}
		}
		public ManagedObjectReference PatchManager
		{
			get
			{
				return this._patchManager;
			}
			set
			{
				this._patchManager = value;
			}
		}
		public ManagedObjectReference ImageConfigManager
		{
			get
			{
				return this._imageConfigManager;
			}
			set
			{
				this._imageConfigManager = value;
			}
		}
		public ManagedObjectReference BootDeviceSystem
		{
			get
			{
				return this._bootDeviceSystem;
			}
			set
			{
				this._bootDeviceSystem = value;
			}
		}
		public ManagedObjectReference FirmwareSystem
		{
			get
			{
				return this._firmwareSystem;
			}
			set
			{
				this._firmwareSystem = value;
			}
		}
		public ManagedObjectReference HealthStatusSystem
		{
			get
			{
				return this._healthStatusSystem;
			}
			set
			{
				this._healthStatusSystem = value;
			}
		}
		public ManagedObjectReference PciPassthruSystem
		{
			get
			{
				return this._pciPassthruSystem;
			}
			set
			{
				this._pciPassthruSystem = value;
			}
		}
		public ManagedObjectReference LicenseManager
		{
			get
			{
				return this._licenseManager;
			}
			set
			{
				this._licenseManager = value;
			}
		}
		public ManagedObjectReference KernelModuleSystem
		{
			get
			{
				return this._kernelModuleSystem;
			}
			set
			{
				this._kernelModuleSystem = value;
			}
		}
		public ManagedObjectReference AuthenticationManager
		{
			get
			{
				return this._authenticationManager;
			}
			set
			{
				this._authenticationManager = value;
			}
		}
		public ManagedObjectReference PowerSystem
		{
			get
			{
				return this._powerSystem;
			}
			set
			{
				this._powerSystem = value;
			}
		}
		public ManagedObjectReference CacheConfigurationManager
		{
			get
			{
				return this._cacheConfigurationManager;
			}
			set
			{
				this._cacheConfigurationManager = value;
			}
		}
		public ManagedObjectReference EsxAgentHostManager
		{
			get
			{
				return this._esxAgentHostManager;
			}
			set
			{
				this._esxAgentHostManager = value;
			}
		}
		public ManagedObjectReference IscsiManager
		{
			get
			{
				return this._iscsiManager;
			}
			set
			{
				this._iscsiManager = value;
			}
		}
		public ManagedObjectReference VFlashManager
		{
			get
			{
				return this._vFlashManager;
			}
			set
			{
				this._vFlashManager = value;
			}
		}
		public ManagedObjectReference VsanSystem
		{
			get
			{
				return this._vsanSystem;
			}
			set
			{
				this._vsanSystem = value;
			}
		}
		public ManagedObjectReference MessageBusProxy
		{
			get
			{
				return this._messageBusProxy;
			}
			set
			{
				this._messageBusProxy = value;
			}
		}
		public ManagedObjectReference UserDirectory
		{
			get
			{
				return this._userDirectory;
			}
			set
			{
				this._userDirectory = value;
			}
		}
		public ManagedObjectReference AccountManager
		{
			get
			{
				return this._accountManager;
			}
			set
			{
				this._accountManager = value;
			}
		}
		public ManagedObjectReference HostAccessManager
		{
			get
			{
				return this._hostAccessManager;
			}
			set
			{
				this._hostAccessManager = value;
			}
		}
		public ManagedObjectReference GraphicsManager
		{
			get
			{
				return this._graphicsManager;
			}
			set
			{
				this._graphicsManager = value;
			}
		}
		public ManagedObjectReference VsanInternalSystem
		{
			get
			{
				return this._vsanInternalSystem;
			}
			set
			{
				this._vsanInternalSystem = value;
			}
		}
		public ManagedObjectReference CertificateManager
		{
			get
			{
				return this._certificateManager;
			}
			set
			{
				this._certificateManager = value;
			}
		}
		public ManagedObjectReference CryptoManager
		{
			get
			{
				return this._cryptoManager;
			}
			set
			{
				this._cryptoManager = value;
			}
		}
		public HostConfigManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
