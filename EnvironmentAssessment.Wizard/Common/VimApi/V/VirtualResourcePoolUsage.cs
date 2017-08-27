namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualResourcePoolUsage : DynamicData
	{
		protected string _vrpId;
		protected long _cpuReservationMhz;
		protected long _memReservationMB;
		protected long _cpuReservationUsedMhz;
		protected long _memReservationUsedMB;
		public string VrpId
		{
			get
			{
				return this._vrpId;
			}
			set
			{
				this._vrpId = value;
			}
		}
		public long CpuReservationMhz
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
		public long MemReservationMB
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
		public long CpuReservationUsedMhz
		{
			get
			{
				return this._cpuReservationUsedMhz;
			}
			set
			{
				this._cpuReservationUsedMhz = value;
			}
		}
		public long MemReservationUsedMB
		{
			get
			{
				return this._memReservationUsedMB;
			}
			set
			{
				this._memReservationUsedMB = value;
			}
		}
	}
}
