namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfHardwareExport : OvfExport
	{
		protected VirtualDevice _device;
		protected string _vmPath;
		public VirtualDevice Device
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
		public string VmPath
		{
			get
			{
				return this._vmPath;
			}
			set
			{
				this._vmPath = value;
			}
		}
	}
}
