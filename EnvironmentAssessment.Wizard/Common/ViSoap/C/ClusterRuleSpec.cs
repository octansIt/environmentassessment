namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterRuleSpec : ArrayUpdateSpec
	{
		protected ClusterRuleInfo _info;
		public ClusterRuleInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
