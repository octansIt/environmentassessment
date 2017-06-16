namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmSetting : DynamicData
	{
		protected int _toleranceRange;
		protected int _reportingFrequency;
		public int ToleranceRange
		{
			get
			{
				return this._toleranceRange;
			}
			set
			{
				this._toleranceRange = value;
			}
		}
		public int ReportingFrequency
		{
			get
			{
				return this._reportingFrequency;
			}
			set
			{
				this._reportingFrequency = value;
			}
		}
	}
}
