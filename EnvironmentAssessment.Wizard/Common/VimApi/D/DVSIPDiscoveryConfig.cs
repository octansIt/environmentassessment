namespace EnvironmentAssessment.Common.VimApi
{
    public class DVSIPDiscoveryConfig : InheritablePolicy
	{
		protected BoolPolicy _ipDiscoveryEnabled;
		protected BoolPolicy _isTrusted;
		protected IntPolicy _maxBindingDbSize;
		protected DVSStaticIPArray _staticIP;
		public BoolPolicy IpDiscoveryEnabled
		{
			get
			{
				return this._ipDiscoveryEnabled;
			}
			set
			{
				this._ipDiscoveryEnabled = value;
			}
		}
		public BoolPolicy IsTrusted
		{
			get
			{
				return this._isTrusted;
			}
			set
			{
				this._isTrusted = value;
			}
		}
		public IntPolicy MaxBindingDbSize
		{
			get
			{
				return this._maxBindingDbSize;
			}
			set
			{
				this._maxBindingDbSize = value;
			}
		}
		public DVSStaticIPArray StaticIP
		{
			get
			{
				return this._staticIP;
			}
			set
			{
				this._staticIP = value;
			}
		}
	}
}
