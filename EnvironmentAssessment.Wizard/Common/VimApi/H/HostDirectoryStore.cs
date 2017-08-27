namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDirectoryStore : HostAuthenticationStore
	{
		public HostDirectoryStore(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
