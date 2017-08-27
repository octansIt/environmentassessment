namespace EnvironmentAssessment.Common.VimApi
{
	public class DestinationSwitchFull : CannotAccessNetwork
	{
		public new DestinationSwitchFull_LinkedView LinkedView
		{
			get
			{
				return (DestinationSwitchFull_LinkedView)this._linkedView;
			}
		}
	}
}
