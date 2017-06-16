namespace EnvironmentAssessment.Common.VISoap
{
    public class HostAuthenticationManagerInfo : DynamicData
	{
		protected HostAuthenticationStoreInfo[] _authConfig;
		public HostAuthenticationStoreInfo[] AuthConfig
		{
			get
			{
				return this._authConfig;
			}
			set
			{
				this._authConfig = value;
			}
		}
	}
}
