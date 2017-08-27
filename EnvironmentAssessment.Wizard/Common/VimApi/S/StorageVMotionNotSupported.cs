namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageVMotionNotSupported : MigrationFeatureNotSupported
	{
		public new StorageVMotionNotSupported_LinkedView LinkedView
		{
			get
			{
				return (StorageVMotionNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
