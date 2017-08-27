namespace EnvironmentAssessment.Common.VimApi
{
	public class PropertyFilterUpdate : DynamicData
	{
		protected ManagedObjectReference _filter;
		protected ObjectUpdate[] _objectSet;
		protected MissingObject[] _missingSet;
		protected PropertyFilterUpdate_LinkedView _linkedView;
		public ManagedObjectReference Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				this._filter = value;
			}
		}
		public ObjectUpdate[] ObjectSet
		{
			get
			{
				return this._objectSet;
			}
			set
			{
				this._objectSet = value;
			}
		}
		public MissingObject[] MissingSet
		{
			get
			{
				return this._missingSet;
			}
			set
			{
				this._missingSet = value;
			}
		}
		public PropertyFilterUpdate_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
