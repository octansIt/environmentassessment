namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFailoverHostAdmissionControlPolicy_LinkedView
	{
		protected HostSystem[] _failoverHosts;
		public HostSystem[] FailoverHosts
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
	}
}
