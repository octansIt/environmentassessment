namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpConfigSpecIpAddressSpec : DynamicData
	{
		protected string _ipAddress;
		protected int _prefixLength;
		protected string _operation;
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
		public int PrefixLength
		{
			get
			{
				return this._prefixLength;
			}
			set
			{
				this._prefixLength = value;
			}
		}
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
