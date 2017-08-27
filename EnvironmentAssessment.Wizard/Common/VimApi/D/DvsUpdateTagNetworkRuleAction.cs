namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsUpdateTagNetworkRuleAction : DvsNetworkRuleAction
	{
		protected int? _qosTag;
		protected int? _dscpTag;
		public int? QosTag
		{
			get
			{
				return this._qosTag;
			}
			set
			{
				this._qosTag = value;
			}
		}
		public int? DscpTag
		{
			get
			{
				return this._dscpTag;
			}
			set
			{
				this._dscpTag = value;
			}
		}
	}
}
