namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationGlobalIPSettings : DynamicData
	{
		protected string[] _dnsSuffixList;
		protected string[] _dnsServerList;
		public string[] DnsSuffixList
		{
			get
			{
				return this._dnsSuffixList;
			}
			set
			{
				this._dnsSuffixList = value;
			}
		}
		public string[] DnsServerList
		{
			get
			{
				return this._dnsServerList;
			}
			set
			{
				this._dnsServerList = value;
			}
		}
	}
}
