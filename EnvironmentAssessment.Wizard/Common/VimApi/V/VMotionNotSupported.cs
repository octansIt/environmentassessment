namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionNotSupported : VMotionInterfaceIssue
	{
		public new VMotionNotSupported_LinkedView LinkedView
		{
			get
			{
				return (VMotionNotSupported_LinkedView)this._linkedView;
			}
		}
	}
}
