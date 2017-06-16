namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineFlagInfo : DynamicData
	{
		protected bool? _disableAcceleration;
		protected bool? _enableLogging;
		protected bool? _useToe;
		protected bool? _runWithDebugInfo;
		protected string _monitorType;
		protected string _htSharing;
		protected bool? _snapshotDisabled;
		protected bool? _snapshotLocked;
		protected bool? _diskUuidEnabled;
		protected string _virtualMmuUsage;
		protected string _virtualExecUsage;
		protected string _snapshotPowerOffBehavior;
		protected bool? _recordReplayEnabled;
		protected string _faultToleranceType;
		public bool? DisableAcceleration
		{
			get
			{
				return this._disableAcceleration;
			}
			set
			{
				this._disableAcceleration = value;
			}
		}
		public bool? EnableLogging
		{
			get
			{
				return this._enableLogging;
			}
			set
			{
				this._enableLogging = value;
			}
		}
		public bool? UseToe
		{
			get
			{
				return this._useToe;
			}
			set
			{
				this._useToe = value;
			}
		}
		public bool? RunWithDebugInfo
		{
			get
			{
				return this._runWithDebugInfo;
			}
			set
			{
				this._runWithDebugInfo = value;
			}
		}
		public string MonitorType
		{
			get
			{
				return this._monitorType;
			}
			set
			{
				this._monitorType = value;
			}
		}
		public string HtSharing
		{
			get
			{
				return this._htSharing;
			}
			set
			{
				this._htSharing = value;
			}
		}
		public bool? SnapshotDisabled
		{
			get
			{
				return this._snapshotDisabled;
			}
			set
			{
				this._snapshotDisabled = value;
			}
		}
		public bool? SnapshotLocked
		{
			get
			{
				return this._snapshotLocked;
			}
			set
			{
				this._snapshotLocked = value;
			}
		}
		public bool? DiskUuidEnabled
		{
			get
			{
				return this._diskUuidEnabled;
			}
			set
			{
				this._diskUuidEnabled = value;
			}
		}
		public string VirtualMmuUsage
		{
			get
			{
				return this._virtualMmuUsage;
			}
			set
			{
				this._virtualMmuUsage = value;
			}
		}
		public string VirtualExecUsage
		{
			get
			{
				return this._virtualExecUsage;
			}
			set
			{
				this._virtualExecUsage = value;
			}
		}
		public string SnapshotPowerOffBehavior
		{
			get
			{
				return this._snapshotPowerOffBehavior;
			}
			set
			{
				this._snapshotPowerOffBehavior = value;
			}
		}
		public bool? RecordReplayEnabled
		{
			get
			{
				return this._recordReplayEnabled;
			}
			set
			{
				this._recordReplayEnabled = value;
			}
		}
		public string FaultToleranceType
		{
			get
			{
				return this._faultToleranceType;
			}
			set
			{
				this._faultToleranceType = value;
			}
		}
	}
}
