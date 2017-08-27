namespace EnvironmentAssessment.Common.VimApi
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
