namespace EnvironmentAssessment.Common.VimApi
{
	public class BaseConfigInfoBackingInfo : DynamicData
	{
		protected ManagedObjectReference _datastore;
		protected BaseConfigInfoBackingInfo_LinkedView _linkedView;
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
		public BaseConfigInfoBackingInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
