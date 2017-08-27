namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAuthenticationManager_LinkedView
	{
		protected HostAuthenticationStore[] _supportedStore;
		public HostAuthenticationStore[] SupportedStore
		{
			get
			{
				return this._supportedStore;
			}
		}
	}
}
