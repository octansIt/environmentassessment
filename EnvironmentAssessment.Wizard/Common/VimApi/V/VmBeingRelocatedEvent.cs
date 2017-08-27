namespace EnvironmentAssessment.Common.VimApi
{
	public class VmBeingRelocatedEvent : VmRelocateSpecEvent
	{
		protected HostEventArgument _destHost;
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
