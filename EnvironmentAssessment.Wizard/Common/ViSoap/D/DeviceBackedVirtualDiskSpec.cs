namespace EnvironmentAssessment.Common.VISoap
{
    public class DeviceBackedVirtualDiskSpec : VirtualDiskSpec
	{
		protected string _device;
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
	}
}