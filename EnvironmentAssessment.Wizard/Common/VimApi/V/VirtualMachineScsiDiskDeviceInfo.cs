namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineScsiDiskDeviceInfo : VirtualMachineDiskDeviceInfo
	{
		protected HostScsiDisk _disk;
		protected string _transportHint;
		protected int? _lunNumber;
		public HostScsiDisk Disk
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
		public string TransportHint
		{
			get
			{
				return this._transportHint;
			}
			set
			{
				this._transportHint = value;
			}
		}
		public int? LunNumber
		{
			get
			{
				return this._lunNumber;
			}
			set
			{
				this._lunNumber = value;
			}
		}
		public new VirtualMachineScsiDiskDeviceInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualMachineScsiDiskDeviceInfo_LinkedView)this._linkedView;
			}
		}
	}
}
