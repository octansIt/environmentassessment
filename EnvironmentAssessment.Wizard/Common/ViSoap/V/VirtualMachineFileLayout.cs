namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineFileLayout : DynamicData
	{
		protected string[] _configFile;
		protected string[] _logFile;
		protected VirtualMachineFileLayoutDiskLayout[] _disk;
		protected VirtualMachineFileLayoutSnapshotLayout[] _snapshot;
		protected string _swapFile;
		public string[] ConfigFile
		{
			get
			{
				return this._configFile;
			}
			set
			{
				this._configFile = value;
			}
		}
		public string[] LogFile
		{
			get
			{
				return this._logFile;
			}
			set
			{
				this._logFile = value;
			}
		}
		public VirtualMachineFileLayoutDiskLayout[] Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
		public VirtualMachineFileLayoutSnapshotLayout[] Snapshot
		{
			get
			{
				return this._snapshot;
			}
			set
			{
				this._snapshot = value;
			}
		}
		public string SwapFile
		{
			get
			{
				return this._swapFile;
			}
			set
			{
				this._swapFile = value;
			}
		}
	}
}
