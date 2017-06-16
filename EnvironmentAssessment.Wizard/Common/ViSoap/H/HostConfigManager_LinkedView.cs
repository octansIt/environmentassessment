namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConfigManager_LinkedView
	{
		protected HostCpuSchedulerSystem _cpuScheduler;
		protected HostDatastoreSystem _datastoreSystem;
		protected HostMemorySystem _memoryManager;
		protected HostStorageSystem _storageSystem;
		protected HostNetworkSystem _networkSystem;
		protected HostVMotionSystem _vmotionSystem;
		protected HostVirtualNicManager _virtualNicManager;
		protected HostServiceSystem _serviceSystem;
		protected HostFirewallSystem _firewallSystem;
		protected OptionManager _advancedOption;
		protected HostDiagnosticSystem _diagnosticSystem;
		protected HostAutoStartManager _autoStartManager;
		protected HostSnmpSystem _snmpSystem;
		protected HostDateTimeSystem _dateTimeSystem;
		protected HostPatchManager _patchManager;
		protected HostImageConfigManager _imageConfigManager;
		protected HostBootDeviceSystem _bootDeviceSystem;
		protected HostFirmwareSystem _firmwareSystem;
		protected HostHealthStatusSystem _healthStatusSystem;
		protected HostPciPassthruSystem _pciPassthruSystem;
		protected LicenseManager _licenseManager;
		protected HostKernelModuleSystem _kernelModuleSystem;
		protected HostAuthenticationManager _authenticationManager;
		protected HostPowerSystem _powerSystem;
		protected HostCacheConfigurationManager _cacheConfigurationManager;
		protected HostEsxAgentHostManager _esxAgentHostManager;
		protected IscsiManager _iscsiManager;
		protected HostVFlashManager _vFlashManager;
		protected HostVsanSystem _vsanSystem;
		protected HostGraphicsManager _graphicsManager;
		protected HostVsanInternalSystem _vsanInternalSystem;
		public HostCpuSchedulerSystem CpuScheduler
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
		public HostDatastoreSystem DatastoreSystem
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
		public HostMemorySystem MemoryManager
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
		public HostStorageSystem StorageSystem
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
		public HostNetworkSystem NetworkSystem
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
		public HostVMotionSystem VmotionSystem
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
		public HostVirtualNicManager VirtualNicManager
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
		public HostServiceSystem ServiceSystem
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
		public HostFirewallSystem FirewallSystem
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
		public OptionManager AdvancedOption
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
		public HostDiagnosticSystem DiagnosticSystem
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
		public HostAutoStartManager AutoStartManager
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
		public HostSnmpSystem SnmpSystem
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
		public HostDateTimeSystem DateTimeSystem
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
		public HostPatchManager PatchManager
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
		public HostImageConfigManager ImageConfigManager
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
		public HostBootDeviceSystem BootDeviceSystem
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
		public HostFirmwareSystem FirmwareSystem
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
		public HostHealthStatusSystem HealthStatusSystem
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
		public HostPciPassthruSystem PciPassthruSystem
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
		public LicenseManager LicenseManager
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
		public HostKernelModuleSystem KernelModuleSystem
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
		public HostAuthenticationManager AuthenticationManager
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
		public HostPowerSystem PowerSystem
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
		public HostCacheConfigurationManager CacheConfigurationManager
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
		public HostEsxAgentHostManager EsxAgentHostManager
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
		public IscsiManager IscsiManager
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
		public HostVFlashManager VFlashManager
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
		public HostVsanSystem VsanSystem
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
		public HostGraphicsManager GraphicsManager
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
		public HostVsanInternalSystem VsanInternalSystem
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
	}
}
