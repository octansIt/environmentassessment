namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceMetaSpec : DynamicData
	{
		protected ManagedObjectReference _metaDataDatastore;
		protected FaultToleranceMetaSpec_LinkedView _linkedView;
		public ManagedObjectReference MetaDataDatastore
		{
			get
			{
				return this._metaDataDatastore;
			}
			set
			{
				this._metaDataDatastore = value;
			}
		}
		public FaultToleranceMetaSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
