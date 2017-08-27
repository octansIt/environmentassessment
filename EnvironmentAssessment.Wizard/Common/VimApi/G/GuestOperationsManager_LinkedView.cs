namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestOperationsManager_LinkedView
	{
		protected GuestAuthManager _authManager;
		protected GuestFileManager _fileManager;
		protected GuestProcessManager _processManager;
		protected GuestWindowsRegistryManager _guestWindowsRegistryManager;
		protected GuestAliasManager _aliasManager;
		public GuestAuthManager AuthManager
		{
			get
			{
				return this._authManager;
			}
		}
		public GuestFileManager FileManager
		{
			get
			{
				return this._fileManager;
			}
		}
		public GuestProcessManager ProcessManager
		{
			get
			{
				return this._processManager;
			}
		}
		public GuestWindowsRegistryManager GuestWindowsRegistryManager
		{
			get
			{
				return this._guestWindowsRegistryManager;
			}
		}
		public GuestAliasManager AliasManager
		{
			get
			{
				return this._aliasManager;
			}
		}
	}
}
