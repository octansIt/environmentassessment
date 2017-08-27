namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreNotWritableOnHost : InvalidDatastore
	{
		protected ManagedObjectReference _host;
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
		public new DatastoreNotWritableOnHost_LinkedView LinkedView
		{
			get
			{
				return (DatastoreNotWritableOnHost_LinkedView)this._linkedView;
			}
		}
	}
}
