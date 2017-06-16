namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineRelocateSpec : DynamicData
	{
		protected ServiceLocator _service;
		protected ManagedObjectReference _folder;
		protected ManagedObjectReference _datastore;
		protected string _diskMoveType;
		protected ManagedObjectReference _pool;
		protected ManagedObjectReference _host;
		protected VirtualMachineRelocateSpecDiskLocator[] _disk;
		protected VirtualMachineRelocateTransformation? _transform;
		protected VirtualDeviceConfigSpec[] _deviceChange;
		protected VirtualMachineProfileSpec[] _profile;
		protected VirtualMachineRelocateSpec_LinkedView _linkedView;
		public ServiceLocator Service
		{
			get
			{
				return this._service;
			}
			set
			{
				this._service = value;
			}
		}
		public ManagedObjectReference Folder
		{
			get
			{
				return this._folder;
			}
			set
			{
				this._folder = value;
			}
		}
		public ManagedObjectReference Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public string DiskMoveType
		{
			get
			{
				return this._diskMoveType;
			}
			set
			{
				this._diskMoveType = value;
			}
		}
		public ManagedObjectReference Pool
		{
			get
			{
				return this._pool;
			}
			set
			{
				this._pool = value;
			}
		}
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public VirtualMachineRelocateSpecDiskLocator[] Disk
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
		public VirtualMachineRelocateTransformation? Transform
		{
			get
			{
				return this._transform;
			}
			set
			{
				this._transform = value;
			}
		}
		public VirtualDeviceConfigSpec[] DeviceChange
		{
			get
			{
				return this._deviceChange;
			}
			set
			{
				this._deviceChange = value;
			}
		}
		public VirtualMachineProfileSpec[] Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
		public VirtualMachineRelocateSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
