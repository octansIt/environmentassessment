namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterFailoverHostAdmissionControlPolicy : ClusterDasAdmissionControlPolicy
	{
		protected ManagedObjectReference[] _failoverHosts;
		protected int? _failoverLevel;
		protected ClusterFailoverHostAdmissionControlPolicy_LinkedView _linkedView;
		public ManagedObjectReference[] FailoverHosts
		{
			get
			{
				return this._failoverHosts;
			}
			set
			{
				this._failoverHosts = value;
			}
		}
		public int? FailoverLevel
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
		public ClusterFailoverHostAdmissionControlPolicy_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
