namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualEthernetCardResourceAllocation : DynamicData
	{
		protected long? _reservation;
		protected SharesInfo _share;
		protected long? _limit;
		public long? Reservation
		{
			get
			{
				return this._reservation;
			}
			set
			{
				this._reservation = value;
			}
		}
		public SharesInfo Share
		{
			get
			{
				return this._share;
			}
			set
			{
				this._share = value;
			}
		}
		public long? Limit
		{
			get
			{
				return this._limit;
			}
			set
			{
				this._limit = value;
			}
		}
	}
}
