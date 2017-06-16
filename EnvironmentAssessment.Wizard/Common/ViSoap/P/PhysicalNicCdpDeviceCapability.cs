namespace EnvironmentAssessment.Common.VISoap
{
    public class PhysicalNicCdpDeviceCapability : DynamicData
	{
		protected bool _router;
		protected bool _transparentBridge;
		protected bool _sourceRouteBridge;
		protected bool _networkSwitch;
		protected bool _host;
		protected bool _igmpEnabled;
		protected bool _repeater;
		public bool Router
		{
			get
			{
				return this._router;
			}
			set
			{
				this._router = value;
			}
		}
		public bool TransparentBridge
		{
			get
			{
				return this._transparentBridge;
			}
			set
			{
				this._transparentBridge = value;
			}
		}
		public bool SourceRouteBridge
		{
			get
			{
				return this._sourceRouteBridge;
			}
			set
			{
				this._sourceRouteBridge = value;
			}
		}
		public bool NetworkSwitch
		{
			get
			{
				return this._networkSwitch;
			}
			set
			{
				this._networkSwitch = value;
			}
		}
		public bool Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public bool IgmpEnabled
		{
			get
			{
				return this._igmpEnabled;
			}
			set
			{
				this._igmpEnabled = value;
			}
		}
		public bool Repeater
		{
			get
			{
				return this._repeater;
			}
			set
			{
				this._repeater = value;
			}
		}
	}
}
