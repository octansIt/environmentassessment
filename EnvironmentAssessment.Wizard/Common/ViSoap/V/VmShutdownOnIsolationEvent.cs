namespace EnvironmentAssessment.Common.VISoap
{
    public class VmShutdownOnIsolationEvent : VmPoweredOffEvent
	{
		protected HostEventArgument _isolatedHost;
		protected string _shutdownResult;
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
		public string ShutdownResult
		{
			get
			{
				return this._shutdownResult;
			}
			set
			{
				this._shutdownResult = value;
			}
		}
	}
}
