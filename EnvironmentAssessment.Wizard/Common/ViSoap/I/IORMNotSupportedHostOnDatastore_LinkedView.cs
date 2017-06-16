namespace EnvironmentAssessment.Common.VISoap
{
    public class IORMNotSupportedHostOnDatastore_LinkedView
	{
		protected Datastore _datastore;
		protected HostSystem[] _host;
		public Datastore Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public HostSystem[] Host
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
	}
}
