namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsFilterConfigSpec : DvsFilterConfig
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
