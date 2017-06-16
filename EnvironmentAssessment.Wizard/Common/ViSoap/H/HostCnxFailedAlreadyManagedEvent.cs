namespace EnvironmentAssessment.Common.VISoap
{
    public class HostCnxFailedAlreadyManagedEvent : HostEvent
	{
		protected string _serverName;
		public string ServerName
		{
			get
			{
				return this._serverName;
			}
			set
			{
				this._serverName = value;
			}
		}
	}
}
