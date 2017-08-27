namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsVmVnicResourceAllocation : DynamicData
	{
		protected long? _reservationQuota;
		public long? ReservationQuota
		{
			get
			{
				return this._reservationQuota;
			}
			set
			{
				this._reservationQuota = value;
			}
		}
	}
}
