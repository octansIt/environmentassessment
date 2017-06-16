using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class HostRuntimeInfo : DynamicData
	{
		protected HostSystemConnectionState _connectionState;
		protected HostSystemPowerState _powerState = HostSystemPowerState.unknown;
		protected string _standbyMode;
		protected bool _inMaintenanceMode;
		protected DateTime? _bootTime;
		protected HealthSystemRuntime _healthSystemRuntime;
		protected ClusterDasFdmHostState _dasHostState;
		protected HostTpmDigestInfo[] _tpmPcrValues;
		protected long? _cpuCapacityForVm;
		protected long? _memoryCapacityForVm;
		protected VsanHostRuntimeInfo _vsanRuntimeInfo;
		protected HostRuntimeInfoNetworkRuntimeInfo _networkRuntimeInfo;
		protected HostVFlashManagerVFlashResourceRunTimeInfo _vFlashResourceRuntimeInfo;
		protected long? _hostMaxVirtualDiskCapacity;
		public HostSystemConnectionState ConnectionState
		{
			get
			{
				return this._connectionState;
			}
			set
			{
				this._connectionState = value;
			}
		}
		public HostSystemPowerState PowerState
		{
			get
			{
				return this._powerState;
			}
			set
			{
				this._powerState = value;
			}
		}
		public string StandbyMode
		{
			get
			{
				return this._standbyMode;
			}
			set
			{
				this._standbyMode = value;
			}
		}
		public bool InMaintenanceMode
		{
			get
			{
				return this._inMaintenanceMode;
			}
			set
			{
				this._inMaintenanceMode = value;
			}
		}
		public DateTime? BootTime
		{
			get
			{
				return this._bootTime;
			}
			set
			{
				this._bootTime = value;
			}
		}
		public HealthSystemRuntime HealthSystemRuntime
		{
			get
			{
				return this._healthSystemRuntime;
			}
			set
			{
				this._healthSystemRuntime = value;
			}
		}
		public ClusterDasFdmHostState DasHostState
		{
			get
			{
				return this._dasHostState;
			}
			set
			{
				this._dasHostState = value;
			}
		}
		public HostTpmDigestInfo[] TpmPcrValues
		{
			get
			{
				return this._tpmPcrValues;
			}
			set
			{
				this._tpmPcrValues = value;
			}
		}
		public long? CpuCapacityForVm
		{
			get
			{
				return this._cpuCapacityForVm;
			}
			set
			{
				this._cpuCapacityForVm = value;
			}
		}
		public long? MemoryCapacityForVm
		{
			get
			{
				return this._memoryCapacityForVm;
			}
			set
			{
				this._memoryCapacityForVm = value;
			}
		}
		public VsanHostRuntimeInfo VsanRuntimeInfo
		{
			get
			{
				return this._vsanRuntimeInfo;
			}
			set
			{
				this._vsanRuntimeInfo = value;
			}
		}
		public HostRuntimeInfoNetworkRuntimeInfo NetworkRuntimeInfo
		{
			get
			{
				return this._networkRuntimeInfo;
			}
			set
			{
				this._networkRuntimeInfo = value;
			}
		}
		public HostVFlashManagerVFlashResourceRunTimeInfo VFlashResourceRuntimeInfo
		{
			get
			{
				return this._vFlashResourceRuntimeInfo;
			}
			set
			{
				this._vFlashResourceRuntimeInfo = value;
			}
		}
		public long? HostMaxVirtualDiskCapacity
		{
			get
			{
				return this._hostMaxVirtualDiskCapacity;
			}
			set
			{
				this._hostMaxVirtualDiskCapacity = value;
			}
		}
	}
}
