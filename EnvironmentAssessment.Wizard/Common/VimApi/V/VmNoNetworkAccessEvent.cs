namespace EnvironmentAssessment.Common.VimApi
{
	public class VmNoNetworkAccessEvent : VmEvent
	{
		protected HostEventArgument _destHost;
		public HostEventArgument DestHost
		{
			get
			{
				return this._destHost;
			}
			set
			{
				this._destHost = value;
			}
		}
	}
}
