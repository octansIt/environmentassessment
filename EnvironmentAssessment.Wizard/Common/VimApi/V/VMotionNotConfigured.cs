namespace EnvironmentAssessment.Common.VimApi
{
	public class VMotionNotConfigured : VMotionInterfaceIssue
	{
		public new VMotionNotConfigured_LinkedView LinkedView
		{
			get
			{
				return (VMotionNotConfigured_LinkedView)this._linkedView;
			}
		}
	}
}
