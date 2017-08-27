namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterFailoverHostAdmissionControlInfo : ClusterDasAdmissionControlInfo
	{
		protected ClusterFailoverHostAdmissionControlInfoHostStatus[] _hostStatus;
		public ClusterFailoverHostAdmissionControlInfoHostStatus[] HostStatus
		{
			get
			{
				return this._hostStatus;
			}
			set
			{
				this._hostStatus = value;
			}
		}
	}
}
