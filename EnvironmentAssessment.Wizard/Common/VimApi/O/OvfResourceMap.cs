namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfResourceMap : DynamicData
	{
		protected string _source;
		protected ManagedObjectReference _parent;
		protected ResourceConfigSpec _resourceSpec;
		protected ManagedObjectReference _datastore;
		protected OvfResourceMap_LinkedView _linkedView;
		public string Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public ManagedObjectReference Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
		public ResourceConfigSpec ResourceSpec
		{
			get
			{
				return this._resourceSpec;
			}
			set
			{
				this._resourceSpec = value;
			}
		}
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
		public OvfResourceMap_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
