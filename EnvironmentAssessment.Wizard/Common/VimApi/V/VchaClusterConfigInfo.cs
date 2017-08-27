namespace EnvironmentAssessment.Common.VimApi
{
	public class VchaClusterConfigInfo : DynamicData
	{
		protected FailoverNodeInfo _failoverNodeInfo1;
		protected FailoverNodeInfo _failoverNodeInfo2;
		protected WitnessNodeInfo _witnessNodeInfo;
		protected string _state;
		public FailoverNodeInfo FailoverNodeInfo1
		{
			get
			{
				return this._failoverNodeInfo1;
			}
			set
			{
				this._failoverNodeInfo1 = value;
			}
		}
		public FailoverNodeInfo FailoverNodeInfo2
		{
			get
			{
				return this._failoverNodeInfo2;
			}
			set
			{
				this._failoverNodeInfo2 = value;
			}
		}
		public WitnessNodeInfo WitnessNodeInfo
		{
			get
			{
				return this._witnessNodeInfo;
			}
			set
			{
				this._witnessNodeInfo = value;
			}
		}
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
	}
}
