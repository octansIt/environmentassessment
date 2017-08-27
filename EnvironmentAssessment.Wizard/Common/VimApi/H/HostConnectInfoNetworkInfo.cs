namespace EnvironmentAssessment.Common.VimApi
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
