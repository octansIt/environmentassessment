namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIpInconsistentEvent : HostEvent
	{
		protected string _ipAddress;
		protected string _ipAddress2;
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public string IpAddress2
		{
			get
			{
				return this._ipAddress2;
			}
			set
			{
				this._ipAddress2 = value;
			}
		}
	}
}
