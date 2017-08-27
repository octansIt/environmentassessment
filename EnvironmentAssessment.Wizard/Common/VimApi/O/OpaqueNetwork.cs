namespace EnvironmentAssessment.Common.VimApi
{
	public class OpaqueNetwork : Network
	{
		protected OpaqueNetworkCapability _capability;
		protected OptionValue[] _extraConfig;
		public OpaqueNetworkCapability Capability
		{
			get
			{
				return this._capability;
			}
		}
		public OptionValue[] ExtraConfig
		{
			get
			{
				return this._extraConfig;
			}
		}
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
