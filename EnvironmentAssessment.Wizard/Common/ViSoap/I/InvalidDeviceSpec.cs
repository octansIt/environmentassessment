namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidDeviceSpec : InvalidVmConfig
	{
		protected int _deviceIndex;
		public int DeviceIndex
		{
			get
			{
				return this._deviceIndex;
			}
			set
			{
				this._deviceIndex = value;
			}
		}
	}
}
