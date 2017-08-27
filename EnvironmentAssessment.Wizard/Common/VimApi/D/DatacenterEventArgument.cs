namespace EnvironmentAssessment.Common.VimApi
{
	public class DatacenterEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _datacenter;
		protected DatacenterEventArgument_LinkedView _linkedView;
		public ManagedObjectReference Datacenter
		{
			get
			{
				return this._datacenter;
			}
			set
			{
				this._datacenter = value;
			}
		}
		public DatacenterEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
