namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationIPSettingsIpV6AddressSpec : DynamicData
	{
		protected CustomizationIpV6Generator[] _ip;
		protected string[] _gateway;
		public CustomizationIpV6Generator[] Ip
		{
			get
			{
				return this._ip;
			}
			set
			{
				this._ip = value;
			}
		}
		public string[] Gateway
		{
			get
			{
				return this._gateway;
			}
			set
			{
				this._gateway = value;
			}
		}
	}
}
