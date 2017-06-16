namespace EnvironmentAssessment.Common.VISoap
{
    public class HostOpaqueNetworkInfo : DynamicData
	{
		protected string _opaqueNetworkId;
		protected string _opaqueNetworkName;
		protected string _opaqueNetworkType;
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
	}
}
