namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineMemoryReservationSpec : DynamicData
	{
		protected long? _virtualMachineReserved;
		protected string _allocationPolicy;
		public long? VirtualMachineReserved
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
