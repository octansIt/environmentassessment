namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualUSBControllerPciBusSlotInfo : VirtualDevicePciBusSlotInfo
	{
		protected int? _ehciPciSlotNumber;
		public int? EhciPciSlotNumber
		{
			get
			{
				return this._ehciPciSlotNumber;
			}
			set
			{
				this._ehciPciSlotNumber = value;
			}
		}
	}
}
