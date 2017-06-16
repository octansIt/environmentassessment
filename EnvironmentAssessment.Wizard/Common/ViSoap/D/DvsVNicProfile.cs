namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsVNicProfile : ApplyProfile
	{
		protected string _key;
		protected IpAddressProfile _ipConfig;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public IpAddressProfile IpConfig
		{
			get
			{
				return this._ipConfig;
			}
			set
			{
				this._ipConfig = value;
			}
		}
	}
}
