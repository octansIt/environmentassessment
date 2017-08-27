namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineIdeDiskDeviceInfo : VirtualMachineDiskDeviceInfo
	{
		protected VirtualMachineIdeDiskDevicePartitionInfo[] _partitionTable;
		public VirtualMachineIdeDiskDevicePartitionInfo[] PartitionTable
		{
			get
			{
				return this._partitionTable;
			}
			set
			{
				this._partitionTable = value;
			}
		}
		public new VirtualMachineIdeDiskDeviceInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualMachineIdeDiskDeviceInfo_LinkedView)this._linkedView;
			}
		}
	}
}
