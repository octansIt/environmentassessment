namespace EnvironmentAssessment.Common.VISoap
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
