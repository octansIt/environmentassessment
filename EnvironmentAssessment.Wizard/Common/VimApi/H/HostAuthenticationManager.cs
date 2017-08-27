namespace EnvironmentAssessment.Common.VimApi
{
	public class HostAuthenticationManager : ViewBase
	{
		protected HostAuthenticationManagerInfo _info;
		protected ManagedObjectReference[] _supportedStore;
		protected HostAuthenticationManager_LinkedView _linkedView;
		public HostAuthenticationManagerInfo Info
		{
			get
			{
				return this._info;
			}
		}
		public ManagedObjectReference[] SupportedStore
		{
			get
			{
				return this._supportedStore;
			}
		}
		public HostAuthenticationManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public HostAuthenticationManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
