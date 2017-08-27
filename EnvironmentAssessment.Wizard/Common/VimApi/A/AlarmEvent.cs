namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmEvent : Event
	{
		protected AlarmEventArgument _alarm;
		public AlarmEventArgument Alarm
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
