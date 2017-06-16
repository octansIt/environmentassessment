namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualDeviceConnectInfo : DynamicData
	{
		protected bool _startConnected;
		protected bool _allowGuestControl;
		protected bool _connected;
		protected string _status;
		public bool StartConnected
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
		public bool AllowGuestControl
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
		public bool Connected
		{
			get
			{
				return this._connected;
			}
			set
			{
				this._connected = value;
			}
		}
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
	}
}
