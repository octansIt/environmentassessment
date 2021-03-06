namespace EnvironmentAssessment.Common.VimApi
{
	public class ServiceContent_LinkedView
	{
		protected Folder _rootFolder;
		protected PropertyCollector _propertyCollector;
		protected ViewManager _viewManager;
		protected OptionManager _setting;
		protected UserDirectory _userDirectory;
		protected SessionManager _sessionManager;
		protected AuthorizationManager _authorizationManager;
		protected ServiceManager _serviceManager;
		protected PerformanceManager _perfManager;
		protected ScheduledTaskManager _scheduledTaskManager;
		protected AlarmManager _alarmManager;
		protected EventManager _eventManager;
		protected TaskManager _taskManager;
		protected ExtensionManager _extensionManager;
		protected CustomizationSpecManager _customizationSpecManager;
		protected CustomFieldsManager _customFieldsManager;
		protected HostLocalAccountManager _accountManager;
		protected DiagnosticManager _diagnosticManager;
		protected LicenseManager _licenseManager;
		protected SearchIndex _searchIndex;
		protected FileManager _fileManager;
		protected DatastoreNamespaceManager _datastoreNamespaceManager;
		protected VirtualDiskManager _virtualDiskManager;
		protected VirtualizationManager _virtualizationManager;
		protected HostSnmpSystem _snmpSystem;
		protected VirtualMachineProvisioningChecker _vmProvisioningChecker;
		protected VirtualMachineCompatibilityChecker _vmCompatibilityChecker;
		protected OvfManager _ovfManager;
		protected IpPoolManager _ipPoolManager;
		protected DistributedVirtualSwitchManager _dvSwitchManager;
		protected HostProfileManager _hostProfileManager;
		protected ClusterProfileManager _clusterProfileManager;
		protected ProfileComplianceManager _complianceManager;
		protected LocalizationManager _localizationManager;
		protected StorageResourceManager _storageResourceManager;
		protected GuestOperationsManager _guestOperationsManager;
		protected OverheadMemoryManager _overheadMemoryManager;
		protected CertificateManager _certificateManager;
		protected IoFilterManager _ioFilterManager;
		protected VStorageObjectManagerBase _vStorageObjectManager;
		protected HostSpecificationManager _hostSpecManager;
		protected CryptoManager _cryptoManager;
		protected HealthUpdateManager _healthUpdateManager;
		protected FailoverClusterConfigurator _failoverClusterConfigurator;
		protected FailoverClusterManager _failoverClusterManager;
		public Folder RootFolder
		{
			get
			{
				return this._rootFolder;
			}
			set
			{
				this._rootFolder = value;
			}
		}
		public PropertyCollector PropertyCollector
		{
			get
			{
				return this._propertyCollector;
			}
			set
			{
				this._propertyCollector = value;
			}
		}
		public ViewManager ViewManager
		{
			get
			{
				return this._viewManager;
			}
			set
			{
				this._viewManager = value;
			}
		}
		public OptionManager Setting
		{
			get
			{
				return this._setting;
			}
			set
			{
				this._setting = value;
			}
		}
		public UserDirectory UserDirectory
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
		public SessionManager SessionManager
		{
			get
			{
				return this._sessionManager;
			}
			set
			{
				this._sessionManager = value;
			}
		}
		public AuthorizationManager AuthorizationManager
		{
			get
			{
				return this._authorizationManager;
			}
			set
			{
				this._authorizationManager = value;
			}
		}
		public ServiceManager ServiceManager
		{
			get
			{
				return this._serviceManager;
			}
			set
			{
				this._serviceManager = value;
			}
		}
		public PerformanceManager PerfManager
		{
			get
			{
				return this._perfManager;
			}
			set
			{
				this._perfManager = value;
			}
		}
		public ScheduledTaskManager ScheduledTaskManager
		{
			get
			{
				return this._scheduledTaskManager;
			}
			set
			{
				this._scheduledTaskManager = value;
			}
		}
		public AlarmManager AlarmManager
		{
			get
			{
				return this._alarmManager;
			}
			set
			{
				this._alarmManager = value;
			}
		}
		public EventManager EventManager
		{
			get
			{
				return this._eventManager;
			}
			set
			{
				this._eventManager = value;
			}
		}
		public TaskManager TaskManager
		{
			get
			{
				return this._taskManager;
			}
			set
			{
				this._taskManager = value;
			}
		}
		public ExtensionManager ExtensionManager
		{
			get
			{
				return this._extensionManager;
			}
			set
			{
				this._extensionManager = value;
			}
		}
		public CustomizationSpecManager CustomizationSpecManager
		{
			get
			{
				return this._customizationSpecManager;
			}
			set
			{
				this._customizationSpecManager = value;
			}
		}
		public CustomFieldsManager CustomFieldsManager
		{
			get
			{
				return this._customFieldsManager;
			}
			set
			{
				this._customFieldsManager = value;
			}
		}
		public HostLocalAccountManager AccountManager
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
		public DiagnosticManager DiagnosticManager
		{
			get
			{
				return this._diagnosticManager;
			}
			set
			{
				this._diagnosticManager = value;
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
		public SearchIndex SearchIndex
		{
			get
			{
				return this._searchIndex;
			}
			set
			{
				this._searchIndex = value;
			}
		}
		public FileManager FileManager
		{
			get
			{
				return this._fileManager;
			}
			set
			{
				this._fileManager = value;
			}
		}
		public DatastoreNamespaceManager DatastoreNamespaceManager
		{
			get
			{
				return this._datastoreNamespaceManager;
			}
			set
			{
				this._datastoreNamespaceManager = value;
			}
		}
		public VirtualDiskManager VirtualDiskManager
		{
			get
			{
				return this._virtualDiskManager;
			}
			set
			{
				this._virtualDiskManager = value;
			}
		}
		public VirtualizationManager VirtualizationManager
		{
			get
			{
				return this._virtualizationManager;
			}
			set
			{
				this._virtualizationManager = value;
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
		public VirtualMachineProvisioningChecker VmProvisioningChecker
		{
			get
			{
				return this._vmProvisioningChecker;
			}
			set
			{
				this._vmProvisioningChecker = value;
			}
		}
		public VirtualMachineCompatibilityChecker VmCompatibilityChecker
		{
			get
			{
				return this._vmCompatibilityChecker;
			}
			set
			{
				this._vmCompatibilityChecker = value;
			}
		}
		public OvfManager OvfManager
		{
			get
			{
				return this._ovfManager;
			}
			set
			{
				this._ovfManager = value;
			}
		}
		public IpPoolManager IpPoolManager
		{
			get
			{
				return this._ipPoolManager;
			}
			set
			{
				this._ipPoolManager = value;
			}
		}
		public DistributedVirtualSwitchManager DvSwitchManager
		{
			get
			{
				return this._dvSwitchManager;
			}
			set
			{
				this._dvSwitchManager = value;
			}
		}
		public HostProfileManager HostProfileManager
		{
			get
			{
				return this._hostProfileManager;
			}
			set
			{
				this._hostProfileManager = value;
			}
		}
		public ClusterProfileManager ClusterProfileManager
		{
			get
			{
				return this._clusterProfileManager;
			}
			set
			{
				this._clusterProfileManager = value;
			}
		}
		public ProfileComplianceManager ComplianceManager
		{
			get
			{
				return this._complianceManager;
			}
			set
			{
				this._complianceManager = value;
			}
		}
		public LocalizationManager LocalizationManager
		{
			get
			{
				return this._localizationManager;
			}
			set
			{
				this._localizationManager = value;
			}
		}
		public StorageResourceManager StorageResourceManager
		{
			get
			{
				return this._storageResourceManager;
			}
			set
			{
				this._storageResourceManager = value;
			}
		}
		public GuestOperationsManager GuestOperationsManager
		{
			get
			{
				return this._guestOperationsManager;
			}
			set
			{
				this._guestOperationsManager = value;
			}
		}
		public OverheadMemoryManager OverheadMemoryManager
		{
			get
			{
				return this._overheadMemoryManager;
			}
			set
			{
				this._overheadMemoryManager = value;
			}
		}
		public CertificateManager CertificateManager
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
		public IoFilterManager IoFilterManager
		{
			get
			{
				return this._ioFilterManager;
			}
			set
			{
				this._ioFilterManager = value;
			}
		}
		public VStorageObjectManagerBase VStorageObjectManager
		{
			get
			{
				return this._vStorageObjectManager;
			}
			set
			{
				this._vStorageObjectManager = value;
			}
		}
		public HostSpecificationManager HostSpecManager
		{
			get
			{
				return this._hostSpecManager;
			}
			set
			{
				this._hostSpecManager = value;
			}
		}
		public CryptoManager CryptoManager
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
		public HealthUpdateManager HealthUpdateManager
		{
			get
			{
				return this._healthUpdateManager;
			}
			set
			{
				this._healthUpdateManager = value;
			}
		}
		public FailoverClusterConfigurator FailoverClusterConfigurator
		{
			get
			{
				return this._failoverClusterConfigurator;
			}
			set
			{
				this._failoverClusterConfigurator = value;
			}
		}
		public FailoverClusterManager FailoverClusterManager
		{
			get
			{
				return this._failoverClusterManager;
			}
			set
			{
				this._failoverClusterManager = value;
			}
		}
	}
}
