namespace EnvironmentAssessment.Common.VimApi
{
	public class VrpResourceAllocationInfo : ResourceAllocationInfo
	{
		protected long? _reservationLimit;
		public long? ReservationLimit
		{
			get
			{
				return this._reservationLimit;
			}
			set
			{
				this._reservationLimit = value;
			}
		}
	}
}
