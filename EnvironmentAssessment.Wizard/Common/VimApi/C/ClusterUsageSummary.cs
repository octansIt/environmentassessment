namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterUsageSummary : DynamicData
	{
		protected int _totalCpuCapacityMhz;
		protected int _totalMemCapacityMB;
		protected int _cpuReservationMhz;
		protected int _memReservationMB;
		protected int? _poweredOffCpuReservationMhz;
		protected int? _poweredOffMemReservationMB;
		protected int _cpuDemandMhz;
		protected int _memDemandMB;
		protected long _statsGenNumber;
		protected int _cpuEntitledMhz;
		protected int _memEntitledMB;
		protected int _poweredOffVmCount;
		protected int _totalVmCount;
		public int TotalCpuCapacityMhz
		{
			get
			{
				return this._totalCpuCapacityMhz;
			}
			set
			{
				this._totalCpuCapacityMhz = value;
			}
		}
		public int TotalMemCapacityMB
		{
			get
			{
				return this._totalMemCapacityMB;
			}
			set
			{
				this._totalMemCapacityMB = value;
			}
		}
		public int CpuReservationMhz
		{
			get
			{
				return this._cpuReservationMhz;
			}
			set
			{
				this._cpuReservationMhz = value;
			}
		}
		public int MemReservationMB
		{
			get
			{
				return this._memReservationMB;
			}
			set
			{
				this._memReservationMB = value;
			}
		}
		public int? PoweredOffCpuReservationMhz
		{
			get
			{
				return this._poweredOffCpuReservationMhz;
			}
			set
			{
				this._poweredOffCpuReservationMhz = value;
			}
		}
		public int? PoweredOffMemReservationMB
		{
			get
			{
				return this._poweredOffMemReservationMB;
			}
			set
			{
				this._poweredOffMemReservationMB = value;
			}
		}
		public int CpuDemandMhz
		{
			get
			{
				return this._cpuDemandMhz;
			}
			set
			{
				this._cpuDemandMhz = value;
			}
		}
		public int MemDemandMB
		{
			get
			{
				return this._memDemandMB;
			}
			set
			{
				this._memDemandMB = value;
			}
		}
		public long StatsGenNumber
		{
			get
			{
				return this._statsGenNumber;
			}
			set
			{
				this._statsGenNumber = value;
			}
		}
		public int CpuEntitledMhz
		{
			get
			{
				return this._cpuEntitledMhz;
			}
			set
			{
				this._cpuEntitledMhz = value;
			}
		}
		public int MemEntitledMB
		{
			get
			{
				return this._memEntitledMB;
			}
			set
			{
				this._memEntitledMB = value;
			}
		}
		public int PoweredOffVmCount
		{
			get
			{
				return this._poweredOffVmCount;
			}
			set
			{
				this._poweredOffVmCount = value;
			}
		}
		public int TotalVmCount
		{
			get
			{
				return this._totalVmCount;
			}
			set
			{
				this._totalVmCount = value;
			}
		}
	}
}
