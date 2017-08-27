namespace EnvironmentAssessment.Common.VimApi
{
	public class FaultToleranceMetaSpec_LinkedView
	{
		protected Datastore _metaDataDatastore;
		public Datastore MetaDataDatastore
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
	}
}
