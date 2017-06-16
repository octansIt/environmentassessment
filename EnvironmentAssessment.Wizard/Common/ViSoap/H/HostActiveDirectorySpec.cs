namespace EnvironmentAssessment.Common.VISoap
{
    public class HostActiveDirectorySpec : DynamicData
	{
		protected string _domainName;
		protected string _userName;
		protected string _password;
		protected string _camServer;
		protected string _thumbprint;
		public string DomainName
		{
			get
			{
				return this._domainName;
			}
			set
			{
				this._domainName = value;
			}
		}
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
		public string CamServer
		{
			get
			{
				return this._camServer;
			}
			set
			{
				this._camServer = value;
			}
		}
		public string Thumbprint
		{
			get
			{
				return this._thumbprint;
			}
			set
			{
				this._thumbprint = value;
			}
		}
	}
}
