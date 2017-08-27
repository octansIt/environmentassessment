namespace EnvironmentAssessment.Common.VimApi
{
	public class VmPowerOffOnIsolationEvent : VmPoweredOffEvent
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
