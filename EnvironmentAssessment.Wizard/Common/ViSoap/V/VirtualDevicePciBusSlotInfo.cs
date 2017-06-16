namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDevicePciBusSlotInfo : VirtualDeviceBusSlotInfo
	{
		protected int _pciSlotNumber;
		public int PciSlotNumber
		{
			get
			{
				return this._pciSlotNumber;
			}
			set
			{
				this._pciSlotNumber = value;
			}
		}
	}
}
