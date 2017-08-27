namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSNetworkResourceManagementCapability : DynamicData
	{
		protected bool _networkResourceManagementSupported;
		protected int _networkResourcePoolHighShareValue;
		protected bool _qosSupported;
		protected bool _userDefinedNetworkResourcePoolsSupported;
		protected bool? _networkResourceControlVersion3Supported;
		public bool NetworkResourceManagementSupported
		{
			get
			{
				return this._networkResourceManagementSupported;
			}
			set
			{
				this._networkResourceManagementSupported = value;
			}
		}
		public int NetworkResourcePoolHighShareValue
		{
			get
			{
				return this._networkResourcePoolHighShareValue;
			}
			set
			{
				this._networkResourcePoolHighShareValue = value;
			}
		}
		public bool QosSupported
		{
			get
			{
				return this._qosSupported;
			}
			set
			{
				this._qosSupported = value;
			}
		}
		public bool UserDefinedNetworkResourcePoolsSupported
		{
			get
			{
				return this._userDefinedNetworkResourcePoolsSupported;
			}
			set
			{
				this._userDefinedNetworkResourcePoolsSupported = value;
			}
		}
		public bool? NetworkResourceControlVersion3Supported
		{
			get
			{
				return this._networkResourceControlVersion3Supported;
			}
			set
			{
				this._networkResourceControlVersion3Supported = value;
			}
		}
	}
}
