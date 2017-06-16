namespace EnvironmentAssessment.Common.VISoap
{
    public class HostConnectInfoNetworkInfo : DynamicData
	{
		protected NetworkSummary _summary;
		public NetworkSummary Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
	}
}
