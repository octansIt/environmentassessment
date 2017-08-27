namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolResourceUsage : DynamicData
	{
		protected long _reservationUsed;
		protected long _reservationUsedForVm;
		protected long _unreservedForPool;
		protected long _unreservedForVm;
		protected long _overallUsage;
		protected long _maxUsage;
		public long ReservationUsed
		{
			get
			{
				return this._reservationUsed;
			}
			set
			{
				this._reservationUsed = value;
			}
		}
		public long ReservationUsedForVm
		{
			get
			{
				return this._reservationUsedForVm;
			}
			set
			{
				this._reservationUsedForVm = value;
			}
		}
		public long UnreservedForPool
		{
			get
			{
				return this._unreservedForPool;
			}
			set
			{
				this._unreservedForPool = value;
			}
		}
		public long UnreservedForVm
		{
			get
			{
				return this._unreservedForVm;
			}
			set
			{
				this._unreservedForVm = value;
			}
		}
		public long OverallUsage
		{
			get
			{
				return this._overallUsage;
			}
			set
			{
				this._overallUsage = value;
			}
		}
		public long MaxUsage
		{
			get
			{
				return this._maxUsage;
			}
			set
			{
				this._maxUsage = value;
			}
		}
	}
}
