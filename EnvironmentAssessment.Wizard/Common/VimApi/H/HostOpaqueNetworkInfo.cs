namespace EnvironmentAssessment.Common.VimApi
{
	public class HostOpaqueNetworkInfo : DynamicData
	{
		protected string _opaqueNetworkId;
		protected string _opaqueNetworkName;
		protected string _opaqueNetworkType;
		protected string[] _pnicZone;
		protected OpaqueNetworkCapability _capability;
		protected OptionValue[] _extraConfig;
		public string OpaqueNetworkId
		{
			get
			{
				return this._opaqueNetworkId;
			}
			set
			{
				this._opaqueNetworkId = value;
			}
		}
		public string OpaqueNetworkName
		{
			get
			{
				return this._opaqueNetworkName;
			}
			set
			{
				this._opaqueNetworkName = value;
			}
		}
		public string OpaqueNetworkType
		{
			get
			{
				return this._opaqueNetworkType;
			}
			set
			{
				this._opaqueNetworkType = value;
			}
		}
		public string[] PnicZone
		{
			get
			{
				return this._pnicZone;
			}
			set
			{
				this._pnicZone = value;
			}
		}
		public OpaqueNetworkCapability Capability
		{
			get
			{
				return this._capability;
			}
			set
			{
				this._capability = value;
			}
		}
		public OptionValue[] ExtraConfig
		{
			get
			{
				return this._extraConfig;
			}
			set
			{
				this._extraConfig = value;
			}
		}
	}
}
