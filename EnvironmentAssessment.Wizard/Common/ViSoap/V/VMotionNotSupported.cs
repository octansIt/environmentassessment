namespace EnvironmentAssessment.Common.VISoap
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
