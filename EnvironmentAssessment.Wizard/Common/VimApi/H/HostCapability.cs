namespace EnvironmentAssessment.Common.VimApi
{
	public class HostCapability : DynamicData
	{
		protected bool _recursiveResourcePoolsSupported;
		protected bool _cpuMemoryResourceConfigurationSupported;
		protected bool _rebootSupported;
		protected bool _shutdownSupported;
		protected bool _vmotionSupported;
		protected bool _standbySupported;
		protected bool? _ipmiSupported;
		protected int? _maxSupportedVMs;
		protected int? _maxRunningVMs;
		protected int? _maxSupportedVcpus;
		protected int? _maxRegisteredVMs;
		protected bool _datastorePrincipalSupported;
		protected bool _sanSupported;
		protected bool _nfsSupported;
		protected bool _iscsiSupported;
		protected bool _vlanTaggingSupported;
		protected bool _nicTeamingSupported;
		protected bool _highGuestMemSupported;
		protected bool _maintenanceModeSupported;
		protected bool _suspendedRelocateSupported;
		protected bool _restrictedSnapshotRelocateSupported;
		protected bool _perVmSwapFiles;
		protected bool _localSwapDatastoreSupported;
		protected bool _unsharedSwapVMotionSupported;
		protected bool _backgroundSnapshotsSupported;
		protected bool _preAssignedPCIUnitNumbersSupported;
		protected bool _screenshotSupported;
		protected bool _scaledScreenshotSupported;
		protected bool _storageVMotionSupported;
		protected bool _vmotionWithStorageVMotionSupported;
		protected bool? _vmotionAcrossNetworkSupported;
		protected int? _maxNumDisksSVMotion;
		protected bool _hbrNicSelectionSupported;
		protected bool _vrNfcNicSelectionSupported;
		protected bool _recordReplaySupported;
		protected bool _ftSupported;
		protected string _replayUnsupportedReason;
		protected string[] _replayCompatibilityIssues;
		protected bool _smpFtSupported;
		protected string[] _ftCompatibilityIssues;
		protected string[] _smpFtCompatibilityIssues;
		protected int? _maxVcpusPerFtVm;
		protected bool? _loginBySSLThumbprintSupported;
		protected bool _cloneFromSnapshotSupported;
		protected bool _deltaDiskBackingsSupported;
		protected bool _perVMNetworkTrafficShapingSupported;
		protected bool _tpmSupported;
		protected HostCpuIdInfo[] _supportedCpuFeature;
		protected bool _virtualExecUsageSupported;
		protected bool _storageIORMSupported;
		protected bool _vmDirectPathGen2Supported;
		protected string[] _vmDirectPathGen2UnsupportedReason;
		protected string _vmDirectPathGen2UnsupportedReasonExtended;
		protected int[] _supportedVmfsMajorVersion;
		protected bool _vStorageCapable;
		protected bool _snapshotRelayoutSupported;
		protected bool? _firewallIpRulesSupported;
		protected bool? _servicePackageInfoSupported;
		protected int? _maxHostRunningVms;
		protected int? _maxHostSupportedVcpus;
		protected bool _vmfsDatastoreMountCapable;
		protected bool _eightPlusHostVmfsSharedAccessSupported;
		protected bool _nestedHVSupported;
		protected bool _vPMCSupported;
		protected bool _interVMCommunicationThroughVMCISupported;
		protected bool? _scheduledHardwareUpgradeSupported;
		protected bool _featureCapabilitiesSupported;
		protected bool _latencySensitivitySupported;
		protected bool? _storagePolicySupported;
		protected bool _accel3dSupported;
		protected bool? _reliableMemoryAware;
		protected bool? _multipleNetworkStackInstanceSupported;
		protected bool? _messageBusProxySupported;
		protected bool? _vsanSupported;
		protected bool? _vFlashSupported;
		protected bool? _hostAccessManagerSupported;
		protected bool _provisioningNicSelectionSupported;
		protected bool? _nfs41Supported;
		protected bool? _nfs41Krb5iSupported;
		protected bool? _turnDiskLocatorLedSupported;
		protected bool? _virtualVolumeDatastoreSupported;
		protected bool? _markAsSsdSupported;
		protected bool? _markAsLocalSupported;
		protected bool? _smartCardAuthenticationSupported;
		protected bool? _cryptoSupported;
		protected bool? _oneKVolumeAPIsSupported;
		protected bool? _gatewayOnNicSupported;
		protected bool? _upitSupported;
		protected bool? _cpuHwMmuSupported;
		protected bool? _encryptedVMotionSupported;
		protected bool? _encryptionChangeOnAddRemoveSupported;
		protected bool? _encryptionHotOperationSupported;
		protected bool? _encryptionWithSnapshotsSupported;
		protected bool? _encryptionFaultToleranceSupported;
		protected bool? _encryptionMemorySaveSupported;
		protected bool? _encryptionRDMSupported;
		protected bool? _encryptionVFlashSupported;
		protected bool? _encryptionCBRCSupported;
		protected bool? _encryptionHBRSupported;
		public bool RecursiveResourcePoolsSupported
		{
			get
			{
				return this._recursiveResourcePoolsSupported;
			}
			set
			{
				this._recursiveResourcePoolsSupported = value;
			}
		}
		public bool CpuMemoryResourceConfigurationSupported
		{
			get
			{
				return this._cpuMemoryResourceConfigurationSupported;
			}
			set
			{
				this._cpuMemoryResourceConfigurationSupported = value;
			}
		}
		public bool RebootSupported
		{
			get
			{
				return this._rebootSupported;
			}
			set
			{
				this._rebootSupported = value;
			}
		}
		public bool ShutdownSupported
		{
			get
			{
				return this._shutdownSupported;
			}
			set
			{
				this._shutdownSupported = value;
			}
		}
		public bool VmotionSupported
		{
			get
			{
				return this._vmotionSupported;
			}
			set
			{
				this._vmotionSupported = value;
			}
		}
		public bool StandbySupported
		{
			get
			{
				return this._standbySupported;
			}
			set
			{
				this._standbySupported = value;
			}
		}
		public bool? IpmiSupported
		{
			get
			{
				return this._ipmiSupported;
			}
			set
			{
				this._ipmiSupported = value;
			}
		}
		public int? MaxSupportedVMs
		{
			get
			{
				return this._maxSupportedVMs;
			}
			set
			{
				this._maxSupportedVMs = value;
			}
		}
		public int? MaxRunningVMs
		{
			get
			{
				return this._maxRunningVMs;
			}
			set
			{
				this._maxRunningVMs = value;
			}
		}
		public int? MaxSupportedVcpus
		{
			get
			{
				return this._maxSupportedVcpus;
			}
			set
			{
				this._maxSupportedVcpus = value;
			}
		}
		public int? MaxRegisteredVMs
		{
			get
			{
				return this._maxRegisteredVMs;
			}
			set
			{
				this._maxRegisteredVMs = value;
			}
		}
		public bool DatastorePrincipalSupported
		{
			get
			{
				return this._datastorePrincipalSupported;
			}
			set
			{
				this._datastorePrincipalSupported = value;
			}
		}
		public bool SanSupported
		{
			get
			{
				return this._sanSupported;
			}
			set
			{
				this._sanSupported = value;
			}
		}
		public bool NfsSupported
		{
			get
			{
				return this._nfsSupported;
			}
			set
			{
				this._nfsSupported = value;
			}
		}
		public bool IscsiSupported
		{
			get
			{
				return this._iscsiSupported;
			}
			set
			{
				this._iscsiSupported = value;
			}
		}
		public bool VlanTaggingSupported
		{
			get
			{
				return this._vlanTaggingSupported;
			}
			set
			{
				this._vlanTaggingSupported = value;
			}
		}
		public bool NicTeamingSupported
		{
			get
			{
				return this._nicTeamingSupported;
			}
			set
			{
				this._nicTeamingSupported = value;
			}
		}
		public bool HighGuestMemSupported
		{
			get
			{
				return this._highGuestMemSupported;
			}
			set
			{
				this._highGuestMemSupported = value;
			}
		}
		public bool MaintenanceModeSupported
		{
			get
			{
				return this._maintenanceModeSupported;
			}
			set
			{
				this._maintenanceModeSupported = value;
			}
		}
		public bool SuspendedRelocateSupported
		{
			get
			{
				return this._suspendedRelocateSupported;
			}
			set
			{
				this._suspendedRelocateSupported = value;
			}
		}
		public bool RestrictedSnapshotRelocateSupported
		{
			get
			{
				return this._restrictedSnapshotRelocateSupported;
			}
			set
			{
				this._restrictedSnapshotRelocateSupported = value;
			}
		}
		public bool PerVmSwapFiles
		{
			get
			{
				return this._perVmSwapFiles;
			}
			set
			{
				this._perVmSwapFiles = value;
			}
		}
		public bool LocalSwapDatastoreSupported
		{
			get
			{
				return this._localSwapDatastoreSupported;
			}
			set
			{
				this._localSwapDatastoreSupported = value;
			}
		}
		public bool UnsharedSwapVMotionSupported
		{
			get
			{
				return this._unsharedSwapVMotionSupported;
			}
			set
			{
				this._unsharedSwapVMotionSupported = value;
			}
		}
		public bool BackgroundSnapshotsSupported
		{
			get
			{
				return this._backgroundSnapshotsSupported;
			}
			set
			{
				this._backgroundSnapshotsSupported = value;
			}
		}
		public bool PreAssignedPCIUnitNumbersSupported
		{
			get
			{
				return this._preAssignedPCIUnitNumbersSupported;
			}
			set
			{
				this._preAssignedPCIUnitNumbersSupported = value;
			}
		}
		public bool ScreenshotSupported
		{
			get
			{
				return this._screenshotSupported;
			}
			set
			{
				this._screenshotSupported = value;
			}
		}
		public bool ScaledScreenshotSupported
		{
			get
			{
				return this._scaledScreenshotSupported;
			}
			set
			{
				this._scaledScreenshotSupported = value;
			}
		}
		public bool StorageVMotionSupported
		{
			get
			{
				return this._storageVMotionSupported;
			}
			set
			{
				this._storageVMotionSupported = value;
			}
		}
		public bool VmotionWithStorageVMotionSupported
		{
			get
			{
				return this._vmotionWithStorageVMotionSupported;
			}
			set
			{
				this._vmotionWithStorageVMotionSupported = value;
			}
		}
		public bool? VmotionAcrossNetworkSupported
		{
			get
			{
				return this._vmotionAcrossNetworkSupported;
			}
			set
			{
				this._vmotionAcrossNetworkSupported = value;
			}
		}
		public int? MaxNumDisksSVMotion
		{
			get
			{
				return this._maxNumDisksSVMotion;
			}
			set
			{
				this._maxNumDisksSVMotion = value;
			}
		}
		public bool HbrNicSelectionSupported
		{
			get
			{
				return this._hbrNicSelectionSupported;
			}
			set
			{
				this._hbrNicSelectionSupported = value;
			}
		}
		public bool VrNfcNicSelectionSupported
		{
			get
			{
				return this._vrNfcNicSelectionSupported;
			}
			set
			{
				this._vrNfcNicSelectionSupported = value;
			}
		}
		public bool RecordReplaySupported
		{
			get
			{
				return this._recordReplaySupported;
			}
			set
			{
				this._recordReplaySupported = value;
			}
		}
		public bool FtSupported
		{
			get
			{
				return this._ftSupported;
			}
			set
			{
				this._ftSupported = value;
			}
		}
		public string ReplayUnsupportedReason
		{
			get
			{
				return this._replayUnsupportedReason;
			}
			set
			{
				this._replayUnsupportedReason = value;
			}
		}
		public string[] ReplayCompatibilityIssues
		{
			get
			{
				return this._replayCompatibilityIssues;
			}
			set
			{
				this._replayCompatibilityIssues = value;
			}
		}
		public bool SmpFtSupported
		{
			get
			{
				return this._smpFtSupported;
			}
			set
			{
				this._smpFtSupported = value;
			}
		}
		public string[] FtCompatibilityIssues
		{
			get
			{
				return this._ftCompatibilityIssues;
			}
			set
			{
				this._ftCompatibilityIssues = value;
			}
		}
		public string[] SmpFtCompatibilityIssues
		{
			get
			{
				return this._smpFtCompatibilityIssues;
			}
			set
			{
				this._smpFtCompatibilityIssues = value;
			}
		}
		public int? MaxVcpusPerFtVm
		{
			get
			{
				return this._maxVcpusPerFtVm;
			}
			set
			{
				this._maxVcpusPerFtVm = value;
			}
		}
		public bool? LoginBySSLThumbprintSupported
		{
			get
			{
				return this._loginBySSLThumbprintSupported;
			}
			set
			{
				this._loginBySSLThumbprintSupported = value;
			}
		}
		public bool CloneFromSnapshotSupported
		{
			get
			{
				return this._cloneFromSnapshotSupported;
			}
			set
			{
				this._cloneFromSnapshotSupported = value;
			}
		}
		public bool DeltaDiskBackingsSupported
		{
			get
			{
				return this._deltaDiskBackingsSupported;
			}
			set
			{
				this._deltaDiskBackingsSupported = value;
			}
		}
		public bool PerVMNetworkTrafficShapingSupported
		{
			get
			{
				return this._perVMNetworkTrafficShapingSupported;
			}
			set
			{
				this._perVMNetworkTrafficShapingSupported = value;
			}
		}
		public bool TpmSupported
		{
			get
			{
				return this._tpmSupported;
			}
			set
			{
				this._tpmSupported = value;
			}
		}
		public HostCpuIdInfo[] SupportedCpuFeature
		{
			get
			{
				return this._supportedCpuFeature;
			}
			set
			{
				this._supportedCpuFeature = value;
			}
		}
		public bool VirtualExecUsageSupported
		{
			get
			{
				return this._virtualExecUsageSupported;
			}
			set
			{
				this._virtualExecUsageSupported = value;
			}
		}
		public bool StorageIORMSupported
		{
			get
			{
				return this._storageIORMSupported;
			}
			set
			{
				this._storageIORMSupported = value;
			}
		}
		public bool VmDirectPathGen2Supported
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
		public string[] VmDirectPathGen2UnsupportedReason
		{
			get
			{
				return this._vmDirectPathGen2UnsupportedReason;
			}
			set
			{
				this._vmDirectPathGen2UnsupportedReason = value;
			}
		}
		public string VmDirectPathGen2UnsupportedReasonExtended
		{
			get
			{
				return this._vmDirectPathGen2UnsupportedReasonExtended;
			}
			set
			{
				this._vmDirectPathGen2UnsupportedReasonExtended = value;
			}
		}
		public int[] SupportedVmfsMajorVersion
		{
			get
			{
				return this._supportedVmfsMajorVersion;
			}
			set
			{
				this._supportedVmfsMajorVersion = value;
			}
		}
		public bool VStorageCapable
		{
			get
			{
				return this._vStorageCapable;
			}
			set
			{
				this._vStorageCapable = value;
			}
		}
		public bool SnapshotRelayoutSupported
		{
			get
			{
				return this._snapshotRelayoutSupported;
			}
			set
			{
				this._snapshotRelayoutSupported = value;
			}
		}
		public bool? FirewallIpRulesSupported
		{
			get
			{
				return this._firewallIpRulesSupported;
			}
			set
			{
				this._firewallIpRulesSupported = value;
			}
		}
		public bool? ServicePackageInfoSupported
		{
			get
			{
				return this._servicePackageInfoSupported;
			}
			set
			{
				this._servicePackageInfoSupported = value;
			}
		}
		public int? MaxHostRunningVms
		{
			get
			{
				return this._maxHostRunningVms;
			}
			set
			{
				this._maxHostRunningVms = value;
			}
		}
		public int? MaxHostSupportedVcpus
		{
			get
			{
				return this._maxHostSupportedVcpus;
			}
			set
			{
				this._maxHostSupportedVcpus = value;
			}
		}
		public bool VmfsDatastoreMountCapable
		{
			get
			{
				return this._vmfsDatastoreMountCapable;
			}
			set
			{
				this._vmfsDatastoreMountCapable = value;
			}
		}
		public bool EightPlusHostVmfsSharedAccessSupported
		{
			get
			{
				return this._eightPlusHostVmfsSharedAccessSupported;
			}
			set
			{
				this._eightPlusHostVmfsSharedAccessSupported = value;
			}
		}
		public bool NestedHVSupported
		{
			get
			{
				return this._nestedHVSupported;
			}
			set
			{
				this._nestedHVSupported = value;
			}
		}
		public bool VPMCSupported
		{
			get
			{
				return this._vPMCSupported;
			}
			set
			{
				this._vPMCSupported = value;
			}
		}
		public bool InterVMCommunicationThroughVMCISupported
		{
			get
			{
				return this._interVMCommunicationThroughVMCISupported;
			}
			set
			{
				this._interVMCommunicationThroughVMCISupported = value;
			}
		}
		public bool? ScheduledHardwareUpgradeSupported
		{
			get
			{
				return this._scheduledHardwareUpgradeSupported;
			}
			set
			{
				this._scheduledHardwareUpgradeSupported = value;
			}
		}
		public bool FeatureCapabilitiesSupported
		{
			get
			{
				return this._featureCapabilitiesSupported;
			}
			set
			{
				this._featureCapabilitiesSupported = value;
			}
		}
		public bool LatencySensitivitySupported
		{
			get
			{
				return this._latencySensitivitySupported;
			}
			set
			{
				this._latencySensitivitySupported = value;
			}
		}
		public bool? StoragePolicySupported
		{
			get
			{
				return this._storagePolicySupported;
			}
			set
			{
				this._storagePolicySupported = value;
			}
		}
		public bool Accel3dSupported
		{
			get
			{
				return this._accel3dSupported;
			}
			set
			{
				this._accel3dSupported = value;
			}
		}
		public bool? ReliableMemoryAware
		{
			get
			{
				return this._reliableMemoryAware;
			}
			set
			{
				this._reliableMemoryAware = value;
			}
		}
		public bool? MultipleNetworkStackInstanceSupported
		{
			get
			{
				return this._multipleNetworkStackInstanceSupported;
			}
			set
			{
				this._multipleNetworkStackInstanceSupported = value;
			}
		}
		public bool? MessageBusProxySupported
		{
			get
			{
				return this._messageBusProxySupported;
			}
			set
			{
				this._messageBusProxySupported = value;
			}
		}
		public bool? VsanSupported
		{
			get
			{
				return this._vsanSupported;
			}
			set
			{
				this._vsanSupported = value;
			}
		}
		public bool? VFlashSupported
		{
			get
			{
				return this._vFlashSupported;
			}
			set
			{
				this._vFlashSupported = value;
			}
		}
		public bool? HostAccessManagerSupported
		{
			get
			{
				return this._hostAccessManagerSupported;
			}
			set
			{
				this._hostAccessManagerSupported = value;
			}
		}
		public bool ProvisioningNicSelectionSupported
		{
			get
			{
				return this._provisioningNicSelectionSupported;
			}
			set
			{
				this._provisioningNicSelectionSupported = value;
			}
		}
		public bool? Nfs41Supported
		{
			get
			{
				return this._nfs41Supported;
			}
			set
			{
				this._nfs41Supported = value;
			}
		}
		public bool? Nfs41Krb5iSupported
		{
			get
			{
				return this._nfs41Krb5iSupported;
			}
			set
			{
				this._nfs41Krb5iSupported = value;
			}
		}
		public bool? TurnDiskLocatorLedSupported
		{
			get
			{
				return this._turnDiskLocatorLedSupported;
			}
			set
			{
				this._turnDiskLocatorLedSupported = value;
			}
		}
		public bool? VirtualVolumeDatastoreSupported
		{
			get
			{
				return this._virtualVolumeDatastoreSupported;
			}
			set
			{
				this._virtualVolumeDatastoreSupported = value;
			}
		}
		public bool? MarkAsSsdSupported
		{
			get
			{
				return this._markAsSsdSupported;
			}
			set
			{
				this._markAsSsdSupported = value;
			}
		}
		public bool? MarkAsLocalSupported
		{
			get
			{
				return this._markAsLocalSupported;
			}
			set
			{
				this._markAsLocalSupported = value;
			}
		}
		public bool? SmartCardAuthenticationSupported
		{
			get
			{
				return this._smartCardAuthenticationSupported;
			}
			set
			{
				this._smartCardAuthenticationSupported = value;
			}
		}
		public bool? CryptoSupported
		{
			get
			{
				return this._cryptoSupported;
			}
			set
			{
				this._cryptoSupported = value;
			}
		}
		public bool? OneKVolumeAPIsSupported
		{
			get
			{
				return this._oneKVolumeAPIsSupported;
			}
			set
			{
				this._oneKVolumeAPIsSupported = value;
			}
		}
		public bool? GatewayOnNicSupported
		{
			get
			{
				return this._gatewayOnNicSupported;
			}
			set
			{
				this._gatewayOnNicSupported = value;
			}
		}
		public bool? UpitSupported
		{
			get
			{
				return this._upitSupported;
			}
			set
			{
				this._upitSupported = value;
			}
		}
		public bool? CpuHwMmuSupported
		{
			get
			{
				return this._cpuHwMmuSupported;
			}
			set
			{
				this._cpuHwMmuSupported = value;
			}
		}
		public bool? EncryptedVMotionSupported
		{
			get
			{
				return this._encryptedVMotionSupported;
			}
			set
			{
				this._encryptedVMotionSupported = value;
			}
		}
		public bool? EncryptionChangeOnAddRemoveSupported
		{
			get
			{
				return this._encryptionChangeOnAddRemoveSupported;
			}
			set
			{
				this._encryptionChangeOnAddRemoveSupported = value;
			}
		}
		public bool? EncryptionHotOperationSupported
		{
			get
			{
				return this._encryptionHotOperationSupported;
			}
			set
			{
				this._encryptionHotOperationSupported = value;
			}
		}
		public bool? EncryptionWithSnapshotsSupported
		{
			get
			{
				return this._encryptionWithSnapshotsSupported;
			}
			set
			{
				this._encryptionWithSnapshotsSupported = value;
			}
		}
		public bool? EncryptionFaultToleranceSupported
		{
			get
			{
				return this._encryptionFaultToleranceSupported;
			}
			set
			{
				this._encryptionFaultToleranceSupported = value;
			}
		}
		public bool? EncryptionMemorySaveSupported
		{
			get
			{
				return this._encryptionMemorySaveSupported;
			}
			set
			{
				this._encryptionMemorySaveSupported = value;
			}
		}
		public bool? EncryptionRDMSupported
		{
			get
			{
				return this._encryptionRDMSupported;
			}
			set
			{
				this._encryptionRDMSupported = value;
			}
		}
		public bool? EncryptionVFlashSupported
		{
			get
			{
				return this._encryptionVFlashSupported;
			}
			set
			{
				this._encryptionVFlashSupported = value;
			}
		}
		public bool? EncryptionCBRCSupported
		{
			get
			{
				return this._encryptionCBRCSupported;
			}
			set
			{
				this._encryptionCBRCSupported = value;
			}
		}
		public bool? EncryptionHBRSupported
		{
			get
			{
				return this._encryptionHBRSupported;
			}
			set
			{
				this._encryptionHBRSupported = value;
			}
		}
	}
}
