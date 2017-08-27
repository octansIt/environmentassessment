namespace EnvironmentAssessment.Common.VimApi
{
	public class IndependentDiskVMotionNotSupported : MigrationFeatureNotSupported
	{
		public new IndependentDiskVMotionNotSupported_LinkedView LinkedView
		{
			get
			{
				return (IndependentDiskVMotionNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
