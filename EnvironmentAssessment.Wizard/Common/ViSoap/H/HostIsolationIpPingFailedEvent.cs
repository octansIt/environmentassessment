namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIsolationIpPingFailedEvent : HostDasEvent
	{
		protected string _isolationIp;
		public string IsolationIp
		{
			get
			{
				return this._isolationIp;
			}
			set
			{
				this._isolationIp = value;
			}
		}
	}
}
