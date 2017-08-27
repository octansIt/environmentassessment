namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppCloneSpecResourceMap : DynamicData
	{
		protected ManagedObjectReference _source;
		protected ManagedObjectReference _parent;
		protected ResourceConfigSpec _resourceSpec;
		protected ManagedObjectReference _location;
		protected VAppCloneSpecResourceMap_LinkedView _linkedView;
		public ManagedObjectReference Source
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
		public ManagedObjectReference Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		public VAppCloneSpecResourceMap_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
