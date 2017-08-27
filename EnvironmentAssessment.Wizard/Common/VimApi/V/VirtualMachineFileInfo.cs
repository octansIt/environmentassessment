namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineFileInfo : DynamicData
	{
		protected string _vmPathName;
		protected string _snapshotDirectory;
		protected string _suspendDirectory;
		protected string _logDirectory;
		protected string _ftMetadataDirectory;
		public string VmPathName
		{
			get
			{
				return this._vmPathName;
			}
			set
			{
				this._vmPathName = value;
			}
		}
		public string SnapshotDirectory
		{
			get
			{
				return this._snapshotDirectory;
			}
			set
			{
				this._snapshotDirectory = value;
			}
		}
		public string SuspendDirectory
		{
			get
			{
				return this._suspendDirectory;
			}
			set
			{
				this._suspendDirectory = value;
			}
		}
		public string LogDirectory
		{
			get
			{
				return this._logDirectory;
			}
			set
			{
				this._logDirectory = value;
			}
		}
		public string FtMetadataDirectory
		{
			get
			{
				return this._ftMetadataDirectory;
			}
			set
			{
				this._ftMetadataDirectory = value;
			}
		}
	}
}
