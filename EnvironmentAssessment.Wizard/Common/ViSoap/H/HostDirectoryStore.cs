namespace EnvironmentAssessment.Common.VISoap
{
    public class HostDirectoryStore : HostAuthenticationStore
	{
		public HostDirectoryStore(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
