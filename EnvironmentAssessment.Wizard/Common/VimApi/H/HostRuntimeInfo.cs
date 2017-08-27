using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class HostRuntimeInfo : DynamicData
	{
		protected HostSystemConnectionState _connectionState;
		protected HostSystemPowerState _powerState = HostSystemPowerState.unknown;
		protected string _standbyMode;
		protected bool _inMaintenanceMode;
		protected bool? _inQuarantineMode;
		protected DateTime? _bootTime;
		protected HealthSystemRuntime _healthSystemRuntime;
		protected ClusterDasFdmHostState _dasHostState;
		protected HostTpmDigestInfo[] _tpmPcrValues;
		protected VsanHostRuntimeInfo _vsanRuntimeInfo;
		protected HostRuntimeInfoNetworkRuntimeInfo _networkRuntimeInfo;
		protected HostVFlashManagerVFlashResourceRunTimeInfo _vFlashResourceRuntimeInfo;
		protected long? _hostMaxVirtualDiskCapacity;
		protected string _cryptoState;
		protected CryptoKeyId _cryptoKeyId;
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
		public bool? InQuarantineMode
		{
			get
			{
				return this._inQuarantineMode;
			}
			set
			{
				this._inQuarantineMode = value;
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
		public string CryptoState
		{
			get
			{
				return this._cryptoState;
			}
			set
			{
				this._cryptoState = value;
			}
		}
		public CryptoKeyId CryptoKeyId
		{
			get
			{
				return this._cryptoKeyId;
			}
			set
			{
				this._cryptoKeyId = value;
			}
		}
	}
}
