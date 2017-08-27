namespace EnvironmentAssessment.Common.VimApi
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
