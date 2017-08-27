namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineConfigOption : DynamicData
	{
		protected string _version;
		protected string _description;
		protected GuestOsDescriptor[] _guestOSDescriptor;
		protected int _guestOSDefaultIndex;
		protected VirtualHardwareOption _hardwareOptions;
		protected VirtualMachineCapability _capabilities;
		protected DatastoreOption _datastore;
		protected VirtualDevice[] _defaultDevice;
		protected string[] _supportedMonitorType;
		protected string[] _supportedOvfEnvironmentTransport;
		protected string[] _supportedOvfInstallTransport;
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public GuestOsDescriptor[] GuestOSDescriptor
		{
			get
			{
				return this._guestOSDescriptor;
			}
			set
			{
				this._guestOSDescriptor = value;
			}
		}
		public int GuestOSDefaultIndex
		{
			get
			{
				return this._guestOSDefaultIndex;
			}
			set
			{
				this._guestOSDefaultIndex = value;
			}
		}
		public VirtualHardwareOption HardwareOptions
		{
			get
			{
				return this._hardwareOptions;
			}
			set
			{
				this._hardwareOptions = value;
			}
		}
		public VirtualMachineCapability Capabilities
		{
			get
			{
				return this._capabilities;
			}
			set
			{
				this._capabilities = value;
			}
		}
		public DatastoreOption Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public VirtualDevice[] DefaultDevice
		{
			get
			{
				return this._defaultDevice;
			}
			set
			{
				this._defaultDevice = value;
			}
		}
		public string[] SupportedMonitorType
		{
			get
			{
				return this._supportedMonitorType;
			}
			set
			{
				this._supportedMonitorType = value;
			}
		}
		public string[] SupportedOvfEnvironmentTransport
		{
			get
			{
				return this._supportedOvfEnvironmentTransport;
			}
			set
			{
				this._supportedOvfEnvironmentTransport = value;
			}
		}
		public string[] SupportedOvfInstallTransport
		{
			get
			{
				return this._supportedOvfInstallTransport;
			}
			set
			{
				this._supportedOvfInstallTransport = value;
			}
		}
	}
}
