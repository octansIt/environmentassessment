namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDeviceDeviceBackingOption : VirtualDeviceBackingOption
	{
		protected BoolOption _autoDetectAvailable;
		public BoolOption AutoDetectAvailable
		{
			get
			{
				return this._autoDetectAvailable;
			}
			set
			{
				this._autoDetectAvailable = value;
			}
		}
	}
}
