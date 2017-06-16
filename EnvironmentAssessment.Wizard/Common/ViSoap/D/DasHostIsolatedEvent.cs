namespace EnvironmentAssessment.Common.VISoap
{
    public class DasHostIsolatedEvent : ClusterEvent
	{
		protected HostEventArgument _isolatedHost;
		public HostEventArgument IsolatedHost
		{
			get
			{
				return this._isolatedHost;
			}
			set
			{
				this._isolatedHost = value;
			}
		}
	}
}
