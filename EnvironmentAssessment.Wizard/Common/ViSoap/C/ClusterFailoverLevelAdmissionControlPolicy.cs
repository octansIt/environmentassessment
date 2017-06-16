namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFailoverLevelAdmissionControlPolicy : ClusterDasAdmissionControlPolicy
	{
		protected int _failoverLevel;
		protected ClusterSlotPolicy _slotPolicy;
		public int FailoverLevel
		{
			get
			{
				return this._failoverLevel;
			}
			set
			{
				this._failoverLevel = value;
			}
		}
		public ClusterSlotPolicy SlotPolicy
		{
			get
			{
				return this._slotPolicy;
			}
			set
			{
				this._slotPolicy = value;
			}
		}
	}
}
