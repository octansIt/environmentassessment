namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLocalAuthentication : HostAuthenticationStore
	{
		public HostLocalAuthentication(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
