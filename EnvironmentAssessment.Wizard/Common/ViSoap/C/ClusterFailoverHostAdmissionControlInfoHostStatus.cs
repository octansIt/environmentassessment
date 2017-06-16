namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterFailoverHostAdmissionControlInfoHostStatus : DynamicData
	{
		protected ManagedObjectReference _host;
		protected ManagedEntityStatus _status;
		protected ClusterFailoverHostAdmissionControlInfoHostStatus_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public ManagedEntityStatus Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public ClusterFailoverHostAdmissionControlInfoHostStatus_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
