namespace EnvironmentAssessment.Common.VISoap
{
    public class IpRange : IpAddress
	{
		protected string _addressPrefix;
		protected int? _prefixLength;
		public string AddressPrefix
		{
			get
			{
				return this._addressPrefix;
			}
			set
			{
				this._addressPrefix = value;
			}
		}
		public int? PrefixLength
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
	}
}
