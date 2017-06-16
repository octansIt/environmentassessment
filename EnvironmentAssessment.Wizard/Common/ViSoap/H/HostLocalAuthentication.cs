namespace EnvironmentAssessment.Common.VISoap
{
    public class HostLocalAuthentication : HostAuthenticationStore
	{
		public HostLocalAuthentication(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
