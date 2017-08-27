namespace EnvironmentAssessment.Common.VimApi
{
	public class LimitExceeded : VimFault
	{
		protected string _property;
		protected int? _limit;
		public string Property
		{
			get
			{
				return this._property;
			}
			set
			{
				this._property = value;
			}
		}
		public int? Limit
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
