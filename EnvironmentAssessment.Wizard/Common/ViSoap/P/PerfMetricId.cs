namespace EnvironmentAssessment.Common.VISoap
{
    public class PerfMetricId : DynamicData
	{
		protected int _counterId;
		protected string _instance;
		public int CounterId
		{
			get
			{
				return this._counterId;
			}
			set
			{
				this._counterId = value;
			}
		}
		public string Instance
		{
			get
			{
				return this._instance;
			}
			set
			{
				this._instance = value;
			}
		}
	}
}
