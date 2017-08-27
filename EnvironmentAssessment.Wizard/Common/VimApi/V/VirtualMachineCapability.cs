namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineCapability : DynamicData
	{
		protected bool _snapshotOperationsSupported;
		protected bool _multipleSnapshotsSupported;
		protected bool _snapshotConfigSupported;
		protected bool _poweredOffSnapshotsSupported;
		protected bool _memorySnapshotsSupported;
		protected bool _revertToSnapshotSupported;
		protected bool _quiescedSnapshotsSupported;
		protected bool _disableSnapshotsSupported;
		protected bool _lockSnapshotsSupported;
		protected bool _consolePreferencesSupported;
		protected bool _cpuFeatureMaskSupported;
		protected bool _s1AcpiManagementSupported;
		protected bool _settingScreenResolutionSupported;
		protected bool _toolsAutoUpdateSupported;
		protected bool _vmNpivWwnSupported;
		protected bool _npivWwnOnNonRdmVmSupported;
		protected bool _vmNpivWwnDisableSupported;
		protected bool _vmNpivWwnUpdateSupported;
		protected bool _swapPlacementSupported;
		protected bool _toolsSyncTimeSupported;
		protected bool _virtualMmuUsageSupported;
		protected bool _diskSharesSupported;
		protected bool _bootOptionsSupported;
		protected bool _bootRetryOptionsSupported;
		protected bool _settingVideoRamSizeSupported;
		protected bool _settingDisplayTopologySupported;
		protected bool _recordReplaySupported;
		protected bool _changeTrackingSupported;
		protected bool _multipleCoresPerSocketSupported;
		protected bool _hostBasedReplicationSupported;
		protected bool _guestAutoLockSupported;
		protected bool _memoryReservationLockSupported;
		protected bool _featureRequirementSupported;
		protected bool _poweredOnMonitorTypeChangeSupported;
		protected bool _seSparseDiskSupported;
		protected bool _nestedHVSupported;
		protected bool _vPMCSupported;
		protected bool? _secureBootSupported;
		public bool SnapshotOperationsSupported
		{
			get
			{
				return this._snapshotOperationsSupported;
			}
			set
			{
				this._snapshotOperationsSupported = value;
			}
		}
		public bool MultipleSnapshotsSupported
		{
			get
			{
				return this._multipleSnapshotsSupported;
			}
			set
			{
				this._multipleSnapshotsSupported = value;
			}
		}
		public bool SnapshotConfigSupported
		{
			get
			{
				return this._snapshotConfigSupported;
			}
			set
			{
				this._snapshotConfigSupported = value;
			}
		}
		public bool PoweredOffSnapshotsSupported
		{
			get
			{
				return this._poweredOffSnapshotsSupported;
			}
			set
			{
				this._poweredOffSnapshotsSupported = value;
			}
		}
		public bool MemorySnapshotsSupported
		{
			get
			{
				return this._memorySnapshotsSupported;
			}
			set
			{
				this._memorySnapshotsSupported = value;
			}
		}
		public bool RevertToSnapshotSupported
		{
			get
			{
				return this._revertToSnapshotSupported;
			}
			set
			{
				this._revertToSnapshotSupported = value;
			}
		}
		public bool QuiescedSnapshotsSupported
		{
			get
			{
				return this._quiescedSnapshotsSupported;
			}
			set
			{
				this._quiescedSnapshotsSupported = value;
			}
		}
		public bool DisableSnapshotsSupported
		{
			get
			{
				return this._disableSnapshotsSupported;
			}
			set
			{
				this._disableSnapshotsSupported = value;
			}
		}
		public bool LockSnapshotsSupported
		{
			get
			{
				return this._lockSnapshotsSupported;
			}
			set
			{
				this._lockSnapshotsSupported = value;
			}
		}
		public bool ConsolePreferencesSupported
		{
			get
			{
				return this._consolePreferencesSupported;
			}
			set
			{
				this._consolePreferencesSupported = value;
			}
		}
		public bool CpuFeatureMaskSupported
		{
			get
			{
				return this._cpuFeatureMaskSupported;
			}
			set
			{
				this._cpuFeatureMaskSupported = value;
			}
		}
		public bool S1AcpiManagementSupported
		{
			get
			{
				return this._s1AcpiManagementSupported;
			}
			set
			{
				this._s1AcpiManagementSupported = value;
			}
		}
		public bool SettingScreenResolutionSupported
		{
			get
			{
				return this._settingScreenResolutionSupported;
			}
			set
			{
				this._settingScreenResolutionSupported = value;
			}
		}
		public bool ToolsAutoUpdateSupported
		{
			get
			{
				return this._toolsAutoUpdateSupported;
			}
			set
			{
				this._toolsAutoUpdateSupported = value;
			}
		}
		public bool VmNpivWwnSupported
		{
			get
			{
				return this._vmNpivWwnSupported;
			}
			set
			{
				this._vmNpivWwnSupported = value;
			}
		}
		public bool NpivWwnOnNonRdmVmSupported
		{
			get
			{
				return this._npivWwnOnNonRdmVmSupported;
			}
			set
			{
				this._npivWwnOnNonRdmVmSupported = value;
			}
		}
		public bool VmNpivWwnDisableSupported
		{
			get
			{
				return this._vmNpivWwnDisableSupported;
			}
			set
			{
				this._vmNpivWwnDisableSupported = value;
			}
		}
		public bool VmNpivWwnUpdateSupported
		{
			get
			{
				return this._vmNpivWwnUpdateSupported;
			}
			set
			{
				this._vmNpivWwnUpdateSupported = value;
			}
		}
		public bool SwapPlacementSupported
		{
			get
			{
				return this._swapPlacementSupported;
			}
			set
			{
				this._swapPlacementSupported = value;
			}
		}
		public bool ToolsSyncTimeSupported
		{
			get
			{
				return this._toolsSyncTimeSupported;
			}
			set
			{
				this._toolsSyncTimeSupported = value;
			}
		}
		public bool VirtualMmuUsageSupported
		{
			get
			{
				return this._virtualMmuUsageSupported;
			}
			set
			{
				this._virtualMmuUsageSupported = value;
			}
		}
		public bool DiskSharesSupported
		{
			get
			{
				return this._diskSharesSupported;
			}
			set
			{
				this._diskSharesSupported = value;
			}
		}
		public bool BootOptionsSupported
		{
			get
			{
				return this._bootOptionsSupported;
			}
			set
			{
				this._bootOptionsSupported = value;
			}
		}
		public bool BootRetryOptionsSupported
		{
			get
			{
				return this._bootRetryOptionsSupported;
			}
			set
			{
				this._bootRetryOptionsSupported = value;
			}
		}
		public bool SettingVideoRamSizeSupported
		{
			get
			{
				return this._settingVideoRamSizeSupported;
			}
			set
			{
				this._settingVideoRamSizeSupported = value;
			}
		}
		public bool SettingDisplayTopologySupported
		{
			get
			{
				return this._settingDisplayTopologySupported;
			}
			set
			{
				this._settingDisplayTopologySupported = value;
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
		public bool ChangeTrackingSupported
		{
			get
			{
				return this._changeTrackingSupported;
			}
			set
			{
				this._changeTrackingSupported = value;
			}
		}
		public bool MultipleCoresPerSocketSupported
		{
			get
			{
				return this._multipleCoresPerSocketSupported;
			}
			set
			{
				this._multipleCoresPerSocketSupported = value;
			}
		}
		public bool HostBasedReplicationSupported
		{
			get
			{
				return this._hostBasedReplicationSupported;
			}
			set
			{
				this._hostBasedReplicationSupported = value;
			}
		}
		public bool GuestAutoLockSupported
		{
			get
			{
				return this._guestAutoLockSupported;
			}
			set
			{
				this._guestAutoLockSupported = value;
			}
		}
		public bool MemoryReservationLockSupported
		{
			get
			{
				return this._memoryReservationLockSupported;
			}
			set
			{
				this._memoryReservationLockSupported = value;
			}
		}
		public bool FeatureRequirementSupported
		{
			get
			{
				return this._featureRequirementSupported;
			}
			set
			{
				this._featureRequirementSupported = value;
			}
		}
		public bool PoweredOnMonitorTypeChangeSupported
		{
			get
			{
				return this._poweredOnMonitorTypeChangeSupported;
			}
			set
			{
				this._poweredOnMonitorTypeChangeSupported = value;
			}
		}
		public bool SeSparseDiskSupported
		{
			get
			{
				return this._seSparseDiskSupported;
			}
			set
			{
				this._seSparseDiskSupported = value;
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
		public bool? SecureBootSupported
		{
			get
			{
				return this._secureBootSupported;
			}
			set
			{
				this._secureBootSupported = value;
			}
		}
	}
}
