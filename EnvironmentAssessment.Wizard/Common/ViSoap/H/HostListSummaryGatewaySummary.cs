namespace EnvironmentAssessment.Common.VISoap
{
    public class HostListSummaryGatewaySummary : DynamicData
	{
		protected string _gatewayType;
		protected string _gatewayId;
		public string GatewayType
		{
			get
			{
				return this._gatewayType;
			}
			set
			{
				this._gatewayType = value;
			}
		}
		public string GatewayId
		{
			get
			{
				return this._gatewayId;
			}
			set
			{
				this._gatewayId = value;
			}
		}
	}
}
