namespace EnvironmentAssessment.Common.VimApi
{
	public class NotSupportedDeviceForFT : VmFaultToleranceIssue
	{
		protected ManagedObjectReference _host;
		protected string _hostName;
		protected ManagedObjectReference _vm;
		protected string _vmName;
		protected string _deviceType;
		protected string _deviceLabel;
		protected NotSupportedDeviceForFT_LinkedView _linkedView;
		public ManagedObjectReference Host
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
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
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
		public string DeviceType
		{
			get
			{
				return this._deviceType;
			}
			set
			{
				this._deviceType = value;
			}
		}
		public string DeviceLabel
		{
			get
			{
				return this._deviceLabel;
			}
			set
			{
				this._deviceLabel = value;
			}
		}
		public NotSupportedDeviceForFT_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
