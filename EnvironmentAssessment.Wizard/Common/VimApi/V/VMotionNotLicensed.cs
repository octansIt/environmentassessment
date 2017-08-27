namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionNotLicensed : VMotionInterfaceIssue
	{
		public new VMotionNotLicensed_LinkedView LinkedView
		{
			get
			{
				return (VMotionNotLicensed_LinkedView)this._linkedView;
			}
		}
	}
}
