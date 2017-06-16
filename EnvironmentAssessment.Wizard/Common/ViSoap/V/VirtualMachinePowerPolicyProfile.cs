namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachinePowerPolicyProfile : DynamicData
	{
		protected string _cpuMode;
		protected int? _monitorTimeout;
		protected int? _hardDiskTimeout;
		protected int? _hibernateTimeout;
		protected int? _suspendTimeout;
		protected int? _forcedThrottle;
		protected int? _minProcessorState;
		protected int? _maxProcessorState;
		public string CpuMode
		{
			get
			{
				return this._cpuMode;
			}
			set
			{
				this._cpuMode = value;
			}
		}
		public int? MonitorTimeout
		{
			get
			{
				return this._monitorTimeout;
			}
			set
			{
				this._monitorTimeout = value;
			}
		}
		public int? HardDiskTimeout
		{
			get
			{
				return this._hardDiskTimeout;
			}
			set
			{
				this._hardDiskTimeout = value;
			}
		}
		public int? HibernateTimeout
		{
			get
			{
				return this._hibernateTimeout;
			}
			set
			{
				this._hibernateTimeout = value;
			}
		}
		public int? SuspendTimeout
		{
			get
			{
				return this._suspendTimeout;
			}
			set
			{
				this._suspendTimeout = value;
			}
		}
		public int? ForcedThrottle
		{
			get
			{
				return this._forcedThrottle;
			}
			set
			{
				this._forcedThrottle = value;
			}
		}
		public int? MinProcessorState
		{
			get
			{
				return this._minProcessorState;
			}
			set
			{
				this._minProcessorState = value;
			}
		}
		public int? MaxProcessorState
		{
			get
			{
				return this._maxProcessorState;
			}
			set
			{
				this._maxProcessorState = value;
			}
		}
	}
}
