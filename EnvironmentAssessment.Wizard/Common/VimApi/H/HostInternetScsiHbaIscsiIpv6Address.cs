namespace EnvironmentAssessment.Common.VimApi
{
	public class HostInternetScsiHbaIscsiIpv6Address : DynamicData
	{
		protected string _address;
		protected int _prefixLength;
		protected string _origin;
		protected string _operation;
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
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
		public string Origin
		{
			get
			{
				return this._origin;
			}
			set
			{
				this._origin = value;
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
