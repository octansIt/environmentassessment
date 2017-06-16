namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidHostConnectionState : InvalidHostState
	{
		public new InvalidHostConnectionState_LinkedView LinkedView
		{
			get
			{
				return (InvalidHostConnectionState_LinkedView)this._linkedView;
			}
		}
	}
}
