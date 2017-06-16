namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestInfo : DynamicData
	{
		protected VirtualMachineToolsStatus? _toolsStatus;
		protected string _toolsVersionStatus;
		protected string _toolsVersionStatus2;
		protected string _toolsRunningStatus;
		protected string _toolsVersion;
		protected VirtualMachineToolsUpdateStatus _toolsUpdateStatus;
		protected string _guestId;
		protected string _guestFamily;
		protected string _guestFullName;
		protected string _hostName;
		protected string _ipAddress;
		protected GuestNicInfo[] _net;
		protected GuestStackInfo[] _ipStack;
		protected GuestDiskInfo[] _disk;
		protected GuestScreenInfo _screen;
		protected string _guestState;
		protected VirtualMachinePowerPolicy _powerPolicy;
		protected string _appHeartbeatStatus;
		protected string _appState;
		protected bool? _guestOperationsReady;
		protected bool? _interactiveGuestOperationsReady;
		protected GuestInfoNamespaceGenerationInfo[] _generationInfo;
		public VirtualMachineToolsStatus? ToolsStatus
		{
			get
			{
				return this._toolsStatus;
			}
			set
			{
				this._toolsStatus = value;
			}
		}
		public string ToolsVersionStatus
		{
			get
			{
				return this._toolsVersionStatus;
			}
			set
			{
				this._toolsVersionStatus = value;
			}
		}
		public string ToolsVersionStatus2
		{
			get
			{
				return this._toolsVersionStatus2;
			}
			set
			{
				this._toolsVersionStatus2 = value;
			}
		}
		public string ToolsRunningStatus
		{
			get
			{
				return this._toolsRunningStatus;
			}
			set
			{
				this._toolsRunningStatus = value;
			}
		}
		public string ToolsVersion
		{
			get
			{
				return this._toolsVersion;
			}
			set
			{
				this._toolsVersion = value;
			}
		}
		public VirtualMachineToolsUpdateStatus ToolsUpdateStatus
		{
			get
			{
				return this._toolsUpdateStatus;
			}
			set
			{
				this._toolsUpdateStatus = value;
			}
		}
		public string GuestId
		{
			get
			{
				return this._guestId;
			}
			set
			{
				this._guestId = value;
			}
		}
		public string GuestFamily
		{
			get
			{
				return this._guestFamily;
			}
			set
			{
				this._guestFamily = value;
			}
		}
		public string GuestFullName
		{
			get
			{
				return this._guestFullName;
			}
			set
			{
				this._guestFullName = value;
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
		public string IpAddress
		{
			get
			{
				return this._ipAddress;
			}
			set
			{
				this._ipAddress = value;
			}
		}
		public GuestNicInfo[] Net
		{
			get
			{
				return this._net;
			}
			set
			{
				this._net = value;
			}
		}
		public GuestStackInfo[] IpStack
		{
			get
			{
				return this._ipStack;
			}
			set
			{
				this._ipStack = value;
			}
		}
		public GuestDiskInfo[] Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
		public GuestScreenInfo Screen
		{
			get
			{
				return this._screen;
			}
			set
			{
				this._screen = value;
			}
		}
		public string GuestState
		{
			get
			{
				return this._guestState;
			}
			set
			{
				this._guestState = value;
			}
		}
		public VirtualMachinePowerPolicy PowerPolicy
		{
			get
			{
				return this._powerPolicy;
			}
			set
			{
				this._powerPolicy = value;
			}
		}
		public string AppHeartbeatStatus
		{
			get
			{
				return this._appHeartbeatStatus;
			}
			set
			{
				this._appHeartbeatStatus = value;
			}
		}
		public string AppState
		{
			get
			{
				return this._appState;
			}
			set
			{
				this._appState = value;
			}
		}
		public bool? GuestOperationsReady
		{
			get
			{
				return this._guestOperationsReady;
			}
			set
			{
				this._guestOperationsReady = value;
			}
		}
		public bool? InteractiveGuestOperationsReady
		{
			get
			{
				return this._interactiveGuestOperationsReady;
			}
			set
			{
				this._interactiveGuestOperationsReady = value;
			}
		}
		public GuestInfoNamespaceGenerationInfo[] GenerationInfo
		{
			get
			{
				return this._generationInfo;
			}
			set
			{
				this._generationInfo = value;
			}
		}
	}
}
