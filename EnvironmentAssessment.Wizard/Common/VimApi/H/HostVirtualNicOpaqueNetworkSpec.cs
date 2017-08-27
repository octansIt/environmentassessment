namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicOpaqueNetworkSpec : DynamicData
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
