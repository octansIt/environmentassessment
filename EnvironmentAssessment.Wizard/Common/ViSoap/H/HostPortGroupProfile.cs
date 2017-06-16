namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPortGroupProfile : PortGroupProfile
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
