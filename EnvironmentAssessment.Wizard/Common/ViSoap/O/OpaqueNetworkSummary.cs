namespace EnvironmentAssessment.Common.VISoap
{
    public class OpaqueNetworkSummary : NetworkSummary
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
		public new OpaqueNetworkSummary_LinkedView LinkedView
		{
			get
			{
				return (OpaqueNetworkSummary_LinkedView)this._linkedView;
			}
		}
	}
}
