namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationSpec : DynamicData
	{
		protected ReplicationGroupId _replicationGroupId;
		public ReplicationGroupId ReplicationGroupId
		{
			get
			{
				return this._replicationGroupId;
			}
			set
			{
				this._replicationGroupId = value;
			}
		}
	}
}
