namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfResourceMap_LinkedView
	{
		protected ResourcePool _parent;
		protected Datastore _datastore;
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
	}
}
