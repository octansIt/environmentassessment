namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineBootOptionsBootableEthernetDevice : VirtualMachineBootOptionsBootableDevice
	{
		protected int _deviceKey;
		public int DeviceKey
		{
			get
			{
				return this._deviceKey;
			}
			set
			{
				this._deviceKey = value;
			}
		}
	}
}
