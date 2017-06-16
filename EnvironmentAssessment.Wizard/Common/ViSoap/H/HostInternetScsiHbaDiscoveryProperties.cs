namespace EnvironmentAssessment.Common.VISoap
{
    public class HostInternetScsiHbaDiscoveryProperties : DynamicData
	{
		protected bool _iSnsDiscoveryEnabled;
		protected string _iSnsDiscoveryMethod;
		protected string _iSnsHost;
		protected bool _slpDiscoveryEnabled;
		protected string _slpDiscoveryMethod;
		protected string _slpHost;
		protected bool _staticTargetDiscoveryEnabled;
		protected bool _sendTargetsDiscoveryEnabled;
		public bool ISnsDiscoveryEnabled
		{
			get
			{
				return this._iSnsDiscoveryEnabled;
			}
			set
			{
				this._iSnsDiscoveryEnabled = value;
			}
		}
		public string ISnsDiscoveryMethod
		{
			get
			{
				return this._iSnsDiscoveryMethod;
			}
			set
			{
				this._iSnsDiscoveryMethod = value;
			}
		}
		public string ISnsHost
		{
			get
			{
				return this._iSnsHost;
			}
			set
			{
				this._iSnsHost = value;
			}
		}
		public bool SlpDiscoveryEnabled
		{
			get
			{
				return this._slpDiscoveryEnabled;
			}
			set
			{
				this._slpDiscoveryEnabled = value;
			}
		}
		public string SlpDiscoveryMethod
		{
			get
			{
				return this._slpDiscoveryMethod;
			}
			set
			{
				this._slpDiscoveryMethod = value;
			}
		}
		public string SlpHost
		{
			get
			{
				return this._slpHost;
			}
			set
			{
				this._slpHost = value;
			}
		}
		public bool StaticTargetDiscoveryEnabled
		{
			get
			{
				return this._staticTargetDiscoveryEnabled;
			}
			set
			{
				this._staticTargetDiscoveryEnabled = value;
			}
		}
		public bool SendTargetsDiscoveryEnabled
		{
			get
			{
				return this._sendTargetsDiscoveryEnabled;
			}
			set
			{
				this._sendTargetsDiscoveryEnabled = value;
			}
		}
	}
}
