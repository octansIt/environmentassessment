namespace EnvironmentAssessment.Common.VISoap
{
    public class DatastoreSummary : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected string _name;
		protected string _url;
		protected long _capacity;
		protected long _freeSpace;
		protected long? _uncommitted;
		protected bool _accessible;
		protected bool? _multipleHostAccess;
		protected string _type;
		protected string _maintenanceMode;
		protected DatastoreSummary_LinkedView _linkedView;
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
		public string Url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}
		public long Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
		public long FreeSpace
		{
			get
			{
				return this._freeSpace;
			}
			set
			{
				this._freeSpace = value;
			}
		}
		public long? Uncommitted
		{
			get
			{
				return this._uncommitted;
			}
			set
			{
				this._uncommitted = value;
			}
		}
		public bool Accessible
		{
			get
			{
				return this._accessible;
			}
			set
			{
				this._accessible = value;
			}
		}
		public bool? MultipleHostAccess
		{
			get
			{
				return this._multipleHostAccess;
			}
			set
			{
				this._multipleHostAccess = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public string MaintenanceMode
		{
			get
			{
				return this._maintenanceMode;
			}
			set
			{
				this._maintenanceMode = value;
			}
		}
		public DatastoreSummary_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
