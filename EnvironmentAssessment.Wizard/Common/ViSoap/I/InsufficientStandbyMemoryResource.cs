namespace EnvironmentAssessment.Common.VISoap
{
    public class InsufficientStandbyMemoryResource : InsufficientStandbyResource
	{
		protected long _available;
		protected long _requested;
		public long Available
		{
			get
			{
				return this._available;
			}
			set
			{
				this._available = value;
			}
		}
		public long Requested
		{
			get
			{
				return this._requested;
			}
			set
			{
				this._requested = value;
			}
		}
	}
}
