namespace EnvironmentAssessment.Common.VimApi
{
	public class VMOnConflictDVPort : CannotAccessNetwork
	{
		public new VMOnConflictDVPort_LinkedView LinkedView
		{
			get
			{
				return (VMOnConflictDVPort_LinkedView)this._linkedView;
			}
		}
	}
}
