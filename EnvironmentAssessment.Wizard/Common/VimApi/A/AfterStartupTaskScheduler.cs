namespace EnvironmentAssessment.Common.VimApi
{
	public class AfterStartupTaskScheduler : TaskScheduler
	{
		protected int _minute;
		public int Minute
		{
			get
			{
				return this._minute;
			}
			set
			{
				this._minute = value;
			}
		}
	}
}
