namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLocalPortCreatedEvent : DvsEvent
	{
		protected DVSHostLocalPortInfo _hostLocalPort;
		public DVSHostLocalPortInfo HostLocalPort
		{
			get
			{
				return this._hostLocalPort;
			}
			set
			{
				this._hostLocalPort = value;
			}
		}
	}
}
