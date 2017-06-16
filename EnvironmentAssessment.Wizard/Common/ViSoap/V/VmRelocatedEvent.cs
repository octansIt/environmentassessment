namespace EnvironmentAssessment.Common.VISoap
{
    public class VmRelocatedEvent : VmRelocateSpecEvent
	{
		protected HostEventArgument _sourceHost;
		protected DatacenterEventArgument _sourceDatacenter;
		protected DatastoreEventArgument _sourceDatastore;
		public HostEventArgument SourceHost
		{
			get
			{
				return this._sourceHost;
			}
			set
			{
				this._sourceHost = value;
			}
		}
		public DatacenterEventArgument SourceDatacenter
		{
			get
			{
				return this._sourceDatacenter;
			}
			set
			{
				this._sourceDatacenter = value;
			}
		}
		public DatastoreEventArgument SourceDatastore
		{
			get
			{
				return this._sourceDatastore;
			}
			set
			{
				this._sourceDatastore = value;
			}
		}
	}
}
