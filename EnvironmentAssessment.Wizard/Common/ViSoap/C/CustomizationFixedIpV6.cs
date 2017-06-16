namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationFixedIpV6 : CustomizationIpV6Generator
	{
		protected string _ipAddress;
		protected int _subnetMask;
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
		public int SubnetMask
		{
			get
			{
				return this._subnetMask;
			}
			set
			{
				this._subnetMask = value;
			}
		}
	}
}
