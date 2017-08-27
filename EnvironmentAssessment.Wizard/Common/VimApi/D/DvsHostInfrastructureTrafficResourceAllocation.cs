namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsHostInfrastructureTrafficResourceAllocation : DynamicData
	{
		protected long? _limit;
		protected SharesInfo _shares;
		protected long? _reservation;
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
		public SharesInfo Shares
		{
			get
			{
				return this._shares;
			}
			set
			{
				this._shares = value;
			}
		}
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
	}
}
