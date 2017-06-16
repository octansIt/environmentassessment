namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNicIpHint : PhysicalNicHint
	{
		protected string _ipSubnet;
		public string IpSubnet
		{
			get
			{
				return this._ipSubnet;
			}
			set
			{
				this._ipSubnet = value;
			}
		}
	}
}
