namespace EnvironmentAssessment.Common.VimApi
{
	public class VmHealthMonitoringStateChangedEvent : ClusterEvent
	{
		protected string _state;
		protected string _prevState;
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public string PrevState
		{
			get
			{
				return this._prevState;
			}
			set
			{
				this._prevState = value;
			}
		}
	}
}
