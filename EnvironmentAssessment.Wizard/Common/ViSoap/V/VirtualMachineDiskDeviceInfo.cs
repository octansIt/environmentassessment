namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineDiskDeviceInfo : VirtualMachineTargetInfo
	{
		protected long? _capacity;
		protected ManagedObjectReference[] _vm;
		protected VirtualMachineDiskDeviceInfo_LinkedView _linkedView;
		public long? Capacity
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
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public VirtualMachineDiskDeviceInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
