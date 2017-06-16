namespace EnvironmentAssessment.Common.VISoap
{
    public class VmFailedMigrateEvent : VmEvent
	{
		protected HostEventArgument _destHost;
		protected LocalizedMethodFault _reason;
		protected DatacenterEventArgument _destDatacenter;
		protected DatastoreEventArgument _destDatastore;
		public HostEventArgument DestHost
		{
			get
			{
				return this._destHost;
			}
			set
			{
				this._destHost = value;
			}
		}
		public LocalizedMethodFault Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public DatacenterEventArgument DestDatacenter
		{
			get
			{
				return this._destDatacenter;
			}
			set
			{
				this._destDatacenter = value;
			}
		}
		public DatastoreEventArgument DestDatastore
		{
			get
			{
				return this._destDatastore;
			}
			set
			{
				this._destDatastore = value;
			}
		}
	}
}
