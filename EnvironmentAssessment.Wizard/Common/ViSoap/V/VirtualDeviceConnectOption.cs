namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDeviceConnectOption : DynamicData
	{
		protected BoolOption _startConnected;
		protected BoolOption _allowGuestControl;
		public BoolOption StartConnected
		{
			get
			{
				return this._startConnected;
			}
			set
			{
				this._startConnected = value;
			}
		}
		public BoolOption AllowGuestControl
		{
			get
			{
				return this._allowGuestControl;
			}
			set
			{
				this._allowGuestControl = value;
			}
		}
	}
}
