namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionAcrossNetworkNotSupported : MigrationFeatureNotSupported
	{
		public new VMotionAcrossNetworkNotSupported_LinkedView LinkedView
		{
			get
			{
				return (VMotionAcrossNetworkNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
