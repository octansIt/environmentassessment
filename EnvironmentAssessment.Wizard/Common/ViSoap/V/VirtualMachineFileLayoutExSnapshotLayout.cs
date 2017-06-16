namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineFileLayoutExSnapshotLayout : DynamicData
	{
		protected ManagedObjectReference _key;
		protected int _dataKey;
		protected int _memoryKey;
		protected VirtualMachineFileLayoutExDiskLayout[] _disk;
		protected VirtualMachineFileLayoutExSnapshotLayout_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public int DataKey
		{
			get
			{
				return this._dataKey;
			}
			set
			{
				this._dataKey = value;
			}
		}
		public int MemoryKey
		{
			get
			{
				return this._memoryKey;
			}
			set
			{
				this._memoryKey = value;
			}
		}
		public VirtualMachineFileLayoutExDiskLayout[] Disk
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
		public VirtualMachineFileLayoutExSnapshotLayout_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
