namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfUnknownDeviceBacking : OvfHardwareExport
	{
		protected VirtualDeviceBackingInfo _backing;
		public VirtualDeviceBackingInfo Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
	}
}
