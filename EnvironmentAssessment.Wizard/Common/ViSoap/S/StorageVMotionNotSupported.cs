namespace EnvironmentAssessment.Common.VISoap
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
