namespace EnvironmentAssessment.Common.VISoap
{
    public class HealthStatusChangedEvent : Event
	{
		protected string _componentId;
		protected string _oldStatus;
		protected string _newStatus;
		protected string _componentName;
		public string ComponentId
		{
			get
			{
				return this._componentId;
			}
			set
			{
				this._componentId = value;
			}
		}
		public string OldStatus
		{
			get
			{
				return this._oldStatus;
			}
			set
			{
				this._oldStatus = value;
			}
		}
		public string NewStatus
		{
			get
			{
				return this._newStatus;
			}
			set
			{
				this._newStatus = value;
			}
		}
		public string ComponentName
		{
			get
			{
				return this._componentName;
			}
			set
			{
				this._componentName = value;
			}
		}
	}
}
