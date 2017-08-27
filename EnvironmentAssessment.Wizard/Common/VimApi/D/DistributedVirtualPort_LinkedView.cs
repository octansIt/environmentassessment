namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualPort_LinkedView
	{
		protected HostSystem _proxyHost;
		public HostSystem ProxyHost
		{
			get
			{
				return this._proxyHost;
			}
			set
			{
				this._proxyHost = value;
			}
		}
	}
}
