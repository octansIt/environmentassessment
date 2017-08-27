namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAuthenticationStore : ViewBase
	{
		protected HostAuthenticationStoreInfo _info;
		public HostAuthenticationStoreInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public HostAuthenticationStore(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
