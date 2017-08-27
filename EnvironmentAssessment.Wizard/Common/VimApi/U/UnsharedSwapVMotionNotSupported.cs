namespace EnvironmentAssessment.Common.VimApi
{
	public class UnsharedSwapVMotionNotSupported : MigrationFeatureNotSupported
	{
		public new UnsharedSwapVMotionNotSupported_LinkedView LinkedView
		{
			get
			{
				return (UnsharedSwapVMotionNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
