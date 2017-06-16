namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppCloneSpecResourceMap_LinkedView
	{
		protected ManagedEntity _source;
		protected ResourcePool _parent;
		protected Datastore _location;
		public ManagedEntity Source
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
		public ResourcePool Parent
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
		public Datastore Location
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
	}
}
