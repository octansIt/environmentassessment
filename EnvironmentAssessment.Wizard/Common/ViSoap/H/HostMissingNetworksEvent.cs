namespace EnvironmentAssessment.Common.VISoap
{
    public class HostMissingNetworksEvent : HostDasEvent
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
