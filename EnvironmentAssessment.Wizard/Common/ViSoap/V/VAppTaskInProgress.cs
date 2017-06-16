namespace EnvironmentAssessment.Common.VISoap
{
    public class VAppTaskInProgress : TaskInProgress
	{
		public new VAppTaskInProgress_LinkedView LinkedView
		{
			get
			{
				return (VAppTaskInProgress_LinkedView)this._linkedView;
			}
		}
	}
}
