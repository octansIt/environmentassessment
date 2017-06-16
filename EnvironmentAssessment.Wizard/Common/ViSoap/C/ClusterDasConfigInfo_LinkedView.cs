namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasConfigInfo_LinkedView
	{
		protected Datastore[] _heartbeatDatastore;
		public Datastore[] HeartbeatDatastore
		{
			get
			{
				return this._heartbeatDatastore;
			}
			set
			{
				this._heartbeatDatastore = value;
			}
		}
	}
}
