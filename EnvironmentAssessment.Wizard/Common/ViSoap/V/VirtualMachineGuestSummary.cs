namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineGuestSummary : DynamicData
	{
		protected string _guestId;
		protected string _guestFullName;
		protected VirtualMachineToolsStatus? _toolsStatus;
		protected string _toolsVersionStatus;
		protected string _toolsVersionStatus2;
		protected string _toolsRunningStatus;
		protected string _hostName;
		protected string _ipAddress;
		protected string[] _ipList;
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
		public string[] IpList
		{
			get
			{
				return this._ipList;
			}
			set
			{
				this._ipList = value;
			}
		}
	}
}
