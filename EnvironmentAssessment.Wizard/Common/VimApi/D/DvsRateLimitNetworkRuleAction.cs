namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsRateLimitNetworkRuleAction : DvsNetworkRuleAction
	{
		protected int _packetsPerSecond;
		public int PacketsPerSecond
		{
			get
			{
				return this._packetsPerSecond;
			}
			set
			{
				this._packetsPerSecond = value;
			}
		}
	}
}
