namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualEthernetCardOpaqueNetworkBackingInfo : VirtualDeviceBackingInfo
	{
		protected string _opaqueNetworkId;
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
