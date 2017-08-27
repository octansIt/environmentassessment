namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourceAllocationInfo : DynamicData
	{
		protected long? _reservation;
		protected bool? _expandableReservation;
		protected long? _limit;
		protected SharesInfo _shares;
		protected long? _overheadLimit;
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
		public bool? ExpandableReservation
		{
			get
			{
				return this._expandableReservation;
			}
			set
			{
				this._expandableReservation = value;
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
		public long? OverheadLimit
		{
			get
			{
				return this._overheadLimit;
			}
			set
			{
				this._overheadLimit = value;
			}
		}
	}
}
