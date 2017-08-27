namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDnsConfigSpec : HostDnsConfig
	{
		protected HostVirtualNicConnection _virtualNicConnection;
		public HostVirtualNicConnection VirtualNicConnection
		{
			get
			{
				return this._virtualNicConnection;
			}
			set
			{
				this._virtualNicConnection = value;
			}
		}
	}
}
