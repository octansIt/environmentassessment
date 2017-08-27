namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmEventArgument_LinkedView
	{
		protected Alarm _alarm;
		public Alarm Alarm
		{
			get
			{
				return this._alarm;
			}
			set
			{
				this._alarm = value;
			}
		}
	}
}
