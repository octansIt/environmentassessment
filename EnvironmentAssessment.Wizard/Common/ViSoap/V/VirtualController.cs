namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualController : VirtualDevice
	{
		protected int _busNumber;
		protected int[] _device;
		public int BusNumber
		{
			get
			{
				return this._busNumber;
			}
			set
			{
				this._busNumber = value;
			}
		}
		public int[] Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
	}
}
