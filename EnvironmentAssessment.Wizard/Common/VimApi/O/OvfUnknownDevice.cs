namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfUnknownDevice : OvfSystemFault
	{
		protected VirtualDevice _device;
		protected string _vmName;
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
		public string VmName
		{
			get
			{
				return this._vmName;
			}
			set
			{
				this._vmName = value;
			}
		}
	}
}
