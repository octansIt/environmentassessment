namespace EnvironmentAssessment.Common.VISoap
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
