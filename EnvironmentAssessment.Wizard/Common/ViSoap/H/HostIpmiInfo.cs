namespace EnvironmentAssessment.Common.VISoap
{
    public class HostIpmiInfo : DynamicData
	{
		protected string _bmcIpAddress;
		protected string _bmcMacAddress;
		protected string _login;
		protected string _password;
		public string BmcIpAddress
		{
			get
			{
				return this._bmcIpAddress;
			}
			set
			{
				this._bmcIpAddress = value;
			}
		}
		public string BmcMacAddress
		{
			get
			{
				return this._bmcMacAddress;
			}
			set
			{
				this._bmcMacAddress = value;
			}
		}
		public string Login
		{
			get
			{
				return this._login;
			}
			set
			{
				this._login = value;
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
	}
}
