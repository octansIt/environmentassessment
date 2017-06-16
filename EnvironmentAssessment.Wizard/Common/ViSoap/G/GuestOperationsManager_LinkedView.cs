namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestOperationsManager_LinkedView
	{
		protected GuestAuthManager _authManager;
		protected GuestFileManager _fileManager;
		protected GuestProcessManager _processManager;
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
	}
}
