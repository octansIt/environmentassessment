namespace EnvironmentAssessment.Common.VISoap
{
    public class HostScsiDisk : ScsiLun
	{
		protected HostDiskDimensionsLba _capacity;
		protected string _devicePath;
		protected bool? _ssd;
		protected bool? _localDisk;
		protected string[] _physicalLocation;
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
	}
}
