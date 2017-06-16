namespace EnvironmentAssessment.Common.VISoap
{
    public class ServiceConsolePortGroupProfile : PortGroupProfile
	{
		protected IpAddressProfile _ipConfig;
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
