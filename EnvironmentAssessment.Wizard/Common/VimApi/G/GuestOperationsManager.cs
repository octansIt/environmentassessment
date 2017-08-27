namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestOperationsManager : ViewBase
	{
		protected ManagedObjectReference _authManager;
		protected ManagedObjectReference _fileManager;
		protected ManagedObjectReference _processManager;
		protected ManagedObjectReference _guestWindowsRegistryManager;
		protected ManagedObjectReference _aliasManager;
		protected GuestOperationsManager_LinkedView _linkedView;
		public ManagedObjectReference AuthManager
		{
			get
			{
				return this._authManager;
			}
		}
		public ManagedObjectReference FileManager
		{
			get
			{
				return this._fileManager;
			}
		}
		public ManagedObjectReference ProcessManager
		{
			get
			{
				return this._processManager;
			}
		}
		public ManagedObjectReference GuestWindowsRegistryManager
		{
			get
			{
				return this._guestWindowsRegistryManager;
			}
		}
		public ManagedObjectReference AliasManager
		{
			get
			{
				return this._aliasManager;
			}
		}
		public GuestOperationsManager_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
		public GuestOperationsManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
