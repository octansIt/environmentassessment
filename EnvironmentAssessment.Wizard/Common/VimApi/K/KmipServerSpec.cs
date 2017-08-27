namespace EnvironmentAssessment.Common.VimApi
{
	public class KmipServerSpec : DynamicData
	{
		protected KeyProviderId _clusterId;
		protected KmipServerInfo _info;
		protected string _password;
		public KeyProviderId ClusterId
		{
			get
			{
				return this._clusterId;
			}
			set
			{
				this._clusterId = value;
			}
		}
		public KmipServerInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
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
