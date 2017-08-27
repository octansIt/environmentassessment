namespace EnvironmentAssessment.Common.VimApi
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
