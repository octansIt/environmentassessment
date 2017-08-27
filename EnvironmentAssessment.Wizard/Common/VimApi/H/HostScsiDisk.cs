namespace EnvironmentAssessment.Common.VimApi
{
	public class HostScsiDisk : ScsiLun
	{
		protected HostDiskDimensionsLba _capacity;
		protected string _devicePath;
		protected bool? _ssd;
		protected bool? _localDisk;
		protected string[] _physicalLocation;
		protected bool? _emulatedDIXDIFEnabled;
		protected VsanHostVsanDiskInfo _vsanDiskInfo;
		protected string _scsiDiskType;
		public HostDiskDimensionsLba Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
		public string DevicePath
		{
			get
			{
				return this._devicePath;
			}
			set
			{
				this._devicePath = value;
			}
		}
		public bool? Ssd
		{
			get
			{
				return this._ssd;
			}
			set
			{
				this._ssd = value;
			}
		}
		public bool? LocalDisk
		{
			get
			{
				return this._localDisk;
			}
			set
			{
				this._localDisk = value;
			}
		}
		public string[] PhysicalLocation
		{
			get
			{
				return this._physicalLocation;
			}
			set
			{
				this._physicalLocation = value;
			}
		}
		public bool? EmulatedDIXDIFEnabled
		{
			get
			{
				return this._emulatedDIXDIFEnabled;
			}
			set
			{
				this._emulatedDIXDIFEnabled = value;
			}
		}
		public VsanHostVsanDiskInfo VsanDiskInfo
		{
			get
			{
				return this._vsanDiskInfo;
			}
			set
			{
				this._vsanDiskInfo = value;
			}
		}
		public string ScsiDiskType
		{
			get
			{
				return this._scsiDiskType;
			}
			set
			{
				this._scsiDiskType = value;
			}
		}
	}
}
