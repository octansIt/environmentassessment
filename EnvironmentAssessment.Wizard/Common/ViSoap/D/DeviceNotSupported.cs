namespace EnvironmentAssessment.Common.VISoap
{
    public class DeviceNotSupported : VirtualHardwareCompatibilityIssue
	{
		protected string _device;
		protected string _reason;
		public string Device
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
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
