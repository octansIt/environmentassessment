namespace EnvironmentAssessment.Common.VISoap
{
    public class AlarmState_LinkedView
	{
		protected ManagedEntity _entity;
		protected Alarm _alarm;
		public ManagedEntity Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
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
