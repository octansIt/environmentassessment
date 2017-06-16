namespace EnvironmentAssessment.Common.VISoap
{
    public class VmHealthMonitoringStateChangedEvent : ClusterEvent
	{
		protected string _state;
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
	}
}