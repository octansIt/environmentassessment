namespace EnvironmentAssessment.Common.VimApi
{
	public class InvalidDatastore : VimFault
	{
		protected ManagedObjectReference _datastore;
		protected string _name;
		protected InvalidDatastore_LinkedView _linkedView;
		public ManagedObjectReference Datastore
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
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public InvalidDatastore_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
