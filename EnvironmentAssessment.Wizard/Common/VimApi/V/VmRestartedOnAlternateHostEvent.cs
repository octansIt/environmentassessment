namespace EnvironmentAssessment.Common.VimApi
{
	public class VmRestartedOnAlternateHostEvent : VmPoweredOnEvent
	{
		protected HostEventArgument _sourceHost;
		public HostEventArgument SourceHost
		{
			get
			{
				return this._sourceHost;
			}
			set
			{
				this._sourceHost = value;
			}
		}
	}
}
