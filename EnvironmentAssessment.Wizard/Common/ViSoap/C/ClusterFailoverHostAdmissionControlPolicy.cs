namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFailoverHostAdmissionControlPolicy : ClusterDasAdmissionControlPolicy
	{
		protected ManagedObjectReference[] _failoverHosts;
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
		public ClusterFailoverHostAdmissionControlPolicy_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
