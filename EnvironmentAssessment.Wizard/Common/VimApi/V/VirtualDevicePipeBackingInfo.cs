namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDevicePipeBackingInfo : VirtualDeviceBackingInfo
	{
		protected string _pipeName;
		public string PipeName
		{
			get
			{
				return this._pipeName;
			}
			set
			{
				this._pipeName = value;
			}
		}
	}
}
