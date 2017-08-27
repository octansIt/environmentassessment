namespace EnvironmentAssessment.Common.VimApi
{
	public class GroupAlarmAction : AlarmAction
	{
		protected AlarmAction[] _action;
		public AlarmAction[] Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}
	}
}
