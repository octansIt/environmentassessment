namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsTrafficFilterConfig : DvsFilterConfig
	{
		protected DvsTrafficRuleset _trafficRuleset;
		public DvsTrafficRuleset TrafficRuleset
		{
			get
			{
				return this._trafficRuleset;
			}
			set
			{
				this._trafficRuleset = value;
			}
		}
	}
}
