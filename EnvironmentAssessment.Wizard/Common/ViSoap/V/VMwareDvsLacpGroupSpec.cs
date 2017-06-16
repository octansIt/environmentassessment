namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareDvsLacpGroupSpec : DynamicData
	{
		protected VMwareDvsLacpGroupConfig _lacpGroupConfig;
		protected string _operation;
		public VMwareDvsLacpGroupConfig LacpGroupConfig
		{
			get
			{
				return this._lacpGroupConfig;
			}
			set
			{
				this._lacpGroupConfig = value;
			}
		}
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
