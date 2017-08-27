namespace EnvironmentAssessment.Common.VimApi
{
	public class NoCompatibleHostWithAccessToDevice : NoCompatibleHost
	{
		public new NoCompatibleHostWithAccessToDevice_LinkedView LinkedView
		{
			get
			{
				return (NoCompatibleHostWithAccessToDevice_LinkedView)this._linkedView;
			}
		}
	}
}
