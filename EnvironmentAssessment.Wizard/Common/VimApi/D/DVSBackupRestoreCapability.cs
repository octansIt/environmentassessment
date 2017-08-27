namespace EnvironmentAssessment.Common.VimApi
{
	public class DVSBackupRestoreCapability : DynamicData
	{
		protected bool _backupRestoreSupported;
		public bool BackupRestoreSupported
		{
			get
			{
				return this._backupRestoreSupported;
			}
			set
			{
				this._backupRestoreSupported = value;
			}
		}
	}
}
