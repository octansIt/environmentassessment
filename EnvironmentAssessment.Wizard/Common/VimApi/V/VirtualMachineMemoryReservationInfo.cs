namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineMemoryReservationInfo : DynamicData
	{
		protected long _virtualMachineMin;
		protected long _virtualMachineMax;
		protected long _virtualMachineReserved;
		protected string _allocationPolicy;
		public long VirtualMachineMin
		{
			get
			{
				return this._virtualMachineMin;
			}
			set
			{
				this._virtualMachineMin = value;
			}
		}
		public long VirtualMachineMax
		{
			get
			{
				return this._virtualMachineMax;
			}
			set
			{
				this._virtualMachineMax = value;
			}
		}
		public long VirtualMachineReserved
		{
			get
			{
				return this._virtualMachineReserved;
			}
			set
			{
				this._virtualMachineReserved = value;
			}
		}
		public string AllocationPolicy
		{
			get
			{
				return this._allocationPolicy;
			}
			set
			{
				this._allocationPolicy = value;
			}
		}
	}
}
