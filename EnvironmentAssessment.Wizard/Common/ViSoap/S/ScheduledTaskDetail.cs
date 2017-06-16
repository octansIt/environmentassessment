namespace EnvironmentAssessment.Common.VISoap
{
    public class ScheduledTaskDetail : TypeDescription
	{
		protected string _frequency;
		public string Frequency
		{
			get
			{
				return this._frequency;
			}
			set
			{
				this._frequency = value;
			}
		}
	}
}
