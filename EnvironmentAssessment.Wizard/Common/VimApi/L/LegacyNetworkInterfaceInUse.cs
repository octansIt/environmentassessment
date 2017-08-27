namespace EnvironmentAssessment.Common.VimApi
{
	public class LegacyNetworkInterfaceInUse : CannotAccessNetwork
	{
		public new LegacyNetworkInterfaceInUse_LinkedView LinkedView
		{
			get
			{
				return (LegacyNetworkInterfaceInUse_LinkedView)this._linkedView;
			}
		}
	}
}
