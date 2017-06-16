namespace EnvironmentAssessment.Common.VISoap
{
    public class OpaqueNetwork : Network
	{
		public new OpaqueNetwork_LinkedView LinkedView
		{
			get
			{
				return (OpaqueNetwork_LinkedView)this._linkedView;
			}
		}
		public OpaqueNetwork(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
