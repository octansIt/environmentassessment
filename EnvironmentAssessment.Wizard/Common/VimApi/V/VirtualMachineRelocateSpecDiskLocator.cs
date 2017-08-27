namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineRelocateSpecDiskLocator : DynamicData
	{
		protected int _diskId;
		protected ManagedObjectReference _datastore;
		protected string _diskMoveType;
		protected VirtualDeviceBackingInfo _diskBackingInfo;
		protected VirtualMachineProfileSpec[] _profile;
		protected VirtualMachineRelocateSpecDiskLocator_LinkedView _linkedView;
		public int DiskId
		{
			get
			{
				return this._diskId;
			}
			set
			{
				this._diskId = value;
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
		public VirtualDeviceBackingInfo DiskBackingInfo
		{
			get
			{
				return this._diskBackingInfo;
			}
			set
			{
				this._diskBackingInfo = value;
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
		public VirtualMachineRelocateSpecDiskLocator_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
