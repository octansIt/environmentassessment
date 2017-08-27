namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSNetworkResourcePoolAllocationInfo : DynamicData
	{
		protected long? _limit;
		protected SharesInfo _shares;
		protected int? _priorityTag;
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
		public int? PriorityTag
		{
			get
			{
				return this._priorityTag;
			}
			set
			{
				this._priorityTag = value;
			}
		}
	}
}
