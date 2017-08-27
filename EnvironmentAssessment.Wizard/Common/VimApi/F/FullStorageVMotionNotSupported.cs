namespace EnvironmentAssessment.Common.VimApi
{
	public class FullStorageVMotionNotSupported : MigrationFeatureNotSupported
	{
		public new FullStorageVMotionNotSupported_LinkedView LinkedView
		{
			get
			{
				return (FullStorageVMotionNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
