namespace EnvironmentAssessment.Common.VimApi
{
	public class AlarmEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _alarm;
		protected AlarmEventArgument_LinkedView _linkedView;
		public ManagedObjectReference Alarm
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
		public AlarmEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
