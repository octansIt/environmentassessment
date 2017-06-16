namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConfigInfo : DynamicData
	{
		protected ManagedObjectReference _host;
		protected AboutInfo _product;
		protected HostHyperThreadScheduleInfo _hyperThread;
		protected ServiceConsoleReservationInfo _consoleReservation;
		protected VirtualMachineMemoryReservationInfo _virtualMachineReservation;
		protected HostStorageDeviceInfo _storageDevice;
		protected HostMultipathStateInfo _multipathState;
		protected HostFileSystemVolumeInfo _fileSystemVolume;
		protected string[] _systemFile;
		protected HostNetworkInfo _network;
		protected HostVMotionInfo _vmotion;
		protected HostVirtualNicManagerInfo _virtualNicManagerInfo;
		protected HostNetCapabilities _capabilities;
		protected HostDatastoreSystemCapabilities _datastoreCapabilities;
		protected HostNetOffloadCapabilities _offloadCapabilities;
		protected HostServiceInfo _service;
		protected HostFirewallInfo _firewall;
		protected HostAutoStartManagerConfig _autoStart;
		protected HostDiagnosticPartition _activeDiagnosticPartition;
		protected OptionValue[] _option;
		protected OptionDef[] _optionDef;
		protected string _datastorePrincipal;
		protected ManagedObjectReference _localSwapDatastore;
		protected HostSystemSwapConfiguration _systemSwapConfiguration;
		protected HostSystemResourceInfo _systemResources;
		protected HostDateTimeInfo _dateTimeInfo;
		protected HostFlagInfo _flags;
		protected bool? _adminDisabled;
		protected HostIpmiInfo _ipmi;
		protected HostSslThumbprintInfo _sslThumbprintInfo;
		protected HostSslThumbprintInfo[] _sslThumbprintData;
		protected sbyte[] _certificate;
		protected HostPciPassthruInfo[] _pciPassthruInfo;
		protected HostAuthenticationManagerInfo _authenticationManagerInfo;
		protected HostFeatureVersionInfo[] _featureVersion;
		protected PowerSystemCapability _powerSystemCapability;
		protected PowerSystemInfo _powerSystemInfo;
		protected HostCacheConfigurationInfo[] _cacheConfigurationInfo;
		protected bool? _wakeOnLanCapable;
		protected HostFeatureCapability[] _featureCapability;
		protected HostFeatureCapability[] _maskedFeatureCapability;
		protected HostVFlashManagerVFlashConfigInfo _vFlashConfigInfo;
		protected VsanHostConfigInfo _vsanHostConfig;
		protected HostGraphicsInfo[] _graphicsInfo;
		protected HostConfigInfo_LinkedView _linkedView;
		public ManagedObjectReference Host
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
		public AboutInfo Product
		{
			get
			{
				return this._product;
			}
			set
			{
				this._product = value;
			}
		}
		public HostHyperThreadScheduleInfo HyperThread
		{
			get
			{
				return this._hyperThread;
			}
			set
			{
				this._hyperThread = value;
			}
		}
		public ServiceConsoleReservationInfo ConsoleReservation
		{
			get
			{
				return this._consoleReservation;
			}
			set
			{
				this._consoleReservation = value;
			}
		}
		public VirtualMachineMemoryReservationInfo VirtualMachineReservation
		{
			get
			{
				return this._virtualMachineReservation;
			}
			set
			{
				this._virtualMachineReservation = value;
			}
		}
		public HostStorageDeviceInfo StorageDevice
		{
			get
			{
				return this._storageDevice;
			}
			set
			{
				this._storageDevice = value;
			}
		}
		public HostMultipathStateInfo MultipathState
		{
			get
			{
				return this._multipathState;
			}
			set
			{
				this._multipathState = value;
			}
		}
		public HostFileSystemVolumeInfo FileSystemVolume
		{
			get
			{
				return this._fileSystemVolume;
			}
			set
			{
				this._fileSystemVolume = value;
			}
		}
		public string[] SystemFile
		{
			get
			{
				return this._systemFile;
			}
			set
			{
				this._systemFile = value;
			}
		}
		public HostNetworkInfo Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public HostVMotionInfo Vmotion
		{
			get
			{
				return this._vmotion;
			}
			set
			{
				this._vmotion = value;
			}
		}
		public HostVirtualNicManagerInfo VirtualNicManagerInfo
		{
			get
			{
				return this._virtualNicManagerInfo;
			}
			set
			{
				this._virtualNicManagerInfo = value;
			}
		}
		public HostNetCapabilities Capabilities
		{
			get
			{
				return this._capabilities;
			}
			set
			{
				this._capabilities = value;
			}
		}
		public HostDatastoreSystemCapabilities DatastoreCapabilities
		{
			get
			{
				return this._datastoreCapabilities;
			}
			set
			{
				this._datastoreCapabilities = value;
			}
		}
		public HostNetOffloadCapabilities OffloadCapabilities
		{
			get
			{
				return this._offloadCapabilities;
			}
			set
			{
				this._offloadCapabilities = value;
			}
		}
		public HostServiceInfo Service
		{
			get
			{
				return this._service;
			}
			set
			{
				this._service = value;
			}
		}
		public HostFirewallInfo Firewall
		{
			get
			{
				return this._firewall;
			}
			set
			{
				this._firewall = value;
			}
		}
		public HostAutoStartManagerConfig AutoStart
		{
			get
			{
				return this._autoStart;
			}
			set
			{
				this._autoStart = value;
			}
		}
		public HostDiagnosticPartition ActiveDiagnosticPartition
		{
			get
			{
				return this._activeDiagnosticPartition;
			}
			set
			{
				this._activeDiagnosticPartition = value;
			}
		}
		public OptionValue[] Option
		{
			get
			{
				return this._option;
			}
			set
			{
				this._option = value;
			}
		}
		public OptionDef[] OptionDef
		{
			get
			{
				return this._optionDef;
			}
			set
			{
				this._optionDef = value;
			}
		}
		public string DatastorePrincipal
		{
			get
			{
				return this._datastorePrincipal;
			}
			set
			{
				this._datastorePrincipal = value;
			}
		}
		public ManagedObjectReference LocalSwapDatastore
		{
			get
			{
				return this._localSwapDatastore;
			}
			set
			{
				this._localSwapDatastore = value;
			}
		}
		public HostSystemSwapConfiguration SystemSwapConfiguration
		{
			get
			{
				return this._systemSwapConfiguration;
			}
			set
			{
				this._systemSwapConfiguration = value;
			}
		}
		public HostSystemResourceInfo SystemResources
		{
			get
			{
				return this._systemResources;
			}
			set
			{
				this._systemResources = value;
			}
		}
		public HostDateTimeInfo DateTimeInfo
		{
			get
			{
				return this._dateTimeInfo;
			}
			set
			{
				this._dateTimeInfo = value;
			}
		}
		public HostFlagInfo Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				this._flags = value;
			}
		}
		public bool? AdminDisabled
		{
			get
			{
				return this._adminDisabled;
			}
			set
			{
				this._adminDisabled = value;
			}
		}
		public HostIpmiInfo Ipmi
		{
			get
			{
				return this._ipmi;
			}
			set
			{
				this._ipmi = value;
			}
		}
		public HostSslThumbprintInfo SslThumbprintInfo
		{
			get
			{
				return this._sslThumbprintInfo;
			}
			set
			{
				this._sslThumbprintInfo = value;
			}
		}
		public HostSslThumbprintInfo[] SslThumbprintData
		{
			get
			{
				return this._sslThumbprintData;
			}
			set
			{
				this._sslThumbprintData = value;
			}
		}
		public sbyte[] Certificate
		{
			get
			{
				return this._certificate;
			}
			set
			{
				this._certificate = value;
			}
		}
		public HostPciPassthruInfo[] PciPassthruInfo
		{
			get
			{
				return this._pciPassthruInfo;
			}
			set
			{
				this._pciPassthruInfo = value;
			}
		}
		public HostAuthenticationManagerInfo AuthenticationManagerInfo
		{
			get
			{
				return this._authenticationManagerInfo;
			}
			set
			{
				this._authenticationManagerInfo = value;
			}
		}
		public HostFeatureVersionInfo[] FeatureVersion
		{
			get
			{
				return this._featureVersion;
			}
			set
			{
				this._featureVersion = value;
			}
		}
		public PowerSystemCapability PowerSystemCapability
		{
			get
			{
				return this._powerSystemCapability;
			}
			set
			{
				this._powerSystemCapability = value;
			}
		}
		public PowerSystemInfo PowerSystemInfo
		{
			get
			{
				return this._powerSystemInfo;
			}
			set
			{
				this._powerSystemInfo = value;
			}
		}
		public HostCacheConfigurationInfo[] CacheConfigurationInfo
		{
			get
			{
				return this._cacheConfigurationInfo;
			}
			set
			{
				this._cacheConfigurationInfo = value;
			}
		}
		public bool? WakeOnLanCapable
		{
			get
			{
				return this._wakeOnLanCapable;
			}
			set
			{
				this._wakeOnLanCapable = value;
			}
		}
		public HostFeatureCapability[] FeatureCapability
		{
			get
			{
				return this._featureCapability;
			}
			set
			{
				this._featureCapability = value;
			}
		}
		public HostFeatureCapability[] MaskedFeatureCapability
		{
			get
			{
				return this._maskedFeatureCapability;
			}
			set
			{
				this._maskedFeatureCapability = value;
			}
		}
		public HostVFlashManagerVFlashConfigInfo VFlashConfigInfo
		{
			get
			{
				return this._vFlashConfigInfo;
			}
			set
			{
				this._vFlashConfigInfo = value;
			}
		}
		public VsanHostConfigInfo VsanHostConfig
		{
			get
			{
				return this._vsanHostConfig;
			}
			set
			{
				this._vsanHostConfig = value;
			}
		}
		public HostGraphicsInfo[] GraphicsInfo
		{
			get
			{
				return this._graphicsInfo;
			}
			set
			{
				this._graphicsInfo = value;
			}
		}
		public HostConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
