namespace EnvironmentAssessment.Common.VISoap
{
    public class DasHostFailedEvent : ClusterEvent
	{
		protected HostEventArgument _failedHost;
		public HostEventArgument FailedHost
		{
			get
			{
				return this._failedHost;
			}
			set
			{
				this._failedHost = value;
			}
		}
	}
}
