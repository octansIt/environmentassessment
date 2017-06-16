namespace EnvironmentAssessment.Common.VISoap
{
    public class AlreadyBeingManaged : HostConnectFault
	{
		protected string _ipAddress;
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
	}
}
