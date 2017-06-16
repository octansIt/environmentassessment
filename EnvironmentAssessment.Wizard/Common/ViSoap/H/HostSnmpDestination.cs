namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSnmpDestination : DynamicData
	{
		protected string _hostName;
		protected int _port;
		protected string _community;
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public int Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
		public string Community
		{
			get
			{
				return this._community;
			}
			set
			{
				this._community = value;
			}
		}
	}
}
