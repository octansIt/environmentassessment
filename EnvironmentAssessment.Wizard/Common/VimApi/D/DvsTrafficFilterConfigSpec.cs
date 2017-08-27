namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsTrafficFilterConfigSpec : DvsTrafficFilterConfig
	{
		protected string _operation;
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
