namespace EnvironmentAssessment.Common.VISoap
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
