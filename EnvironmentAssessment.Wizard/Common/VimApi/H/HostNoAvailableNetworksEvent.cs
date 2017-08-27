namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNoAvailableNetworksEvent : HostDasEvent
	{
		protected string _ips;
		public string Ips
		{
			get
			{
				return this._ips;
			}
			set
			{
				this._ips = value;
			}
		}
	}
}
