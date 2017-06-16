namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterHostPowerAction : ClusterAction
	{
		protected HostPowerOperationType _operationType;
		protected int? _powerConsumptionWatt;
		protected int? _cpuCapacityMHz;
		protected int? _memCapacityMB;
		public HostPowerOperationType OperationType
		{
			get
			{
				return this._operationType;
			}
			set
			{
				this._operationType = value;
			}
		}
		public int? PowerConsumptionWatt
		{
			get
			{
				return this._powerConsumptionWatt;
			}
			set
			{
				this._powerConsumptionWatt = value;
			}
		}
		public int? CpuCapacityMHz
		{
			get
			{
				return this._cpuCapacityMHz;
			}
			set
			{
				this._cpuCapacityMHz = value;
			}
		}
		public int? MemCapacityMB
		{
			get
			{
				return this._memCapacityMB;
			}
			set
			{
				this._memCapacityMB = value;
			}
		}
	}
}
