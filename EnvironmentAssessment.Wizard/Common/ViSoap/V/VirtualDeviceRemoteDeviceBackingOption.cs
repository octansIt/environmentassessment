namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDeviceRemoteDeviceBackingOption : VirtualDeviceBackingOption
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
