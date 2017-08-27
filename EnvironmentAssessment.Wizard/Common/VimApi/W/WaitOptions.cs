namespace EnvironmentAssessment.Common.VimApi
{
	public class WaitOptions : DynamicData
	{
		protected int? _maxWaitSeconds;
		protected int? _maxObjectUpdates;
		public int? MaxWaitSeconds
		{
			get
			{
				return this._maxWaitSeconds;
			}
			set
			{
				this._maxWaitSeconds = value;
			}
		}
		public int? MaxObjectUpdates
		{
			get
			{
				return this._maxObjectUpdates;
			}
			set
			{
				this._maxObjectUpdates = value;
			}
		}
	}
}
