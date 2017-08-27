namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualEthernetCard : VirtualDevice
	{
		protected string _addressType;
		protected string _macAddress;
		protected bool? _wakeOnLanEnabled;
		protected VirtualEthernetCardResourceAllocation _resourceAllocation;
		protected string _externalId;
		protected bool? _uptCompatibilityEnabled;
		public string AddressType
		{
			get
			{
				return this._addressType;
			}
			set
			{
				this._addressType = value;
			}
		}
		public string MacAddress
		{
			get
			{
				return this._macAddress;
			}
			set
			{
				this._macAddress = value;
			}
		}
		public bool? WakeOnLanEnabled
		{
			get
			{
				return this._wakeOnLanEnabled;
			}
			set
			{
				this._wakeOnLanEnabled = value;
			}
		}
		public VirtualEthernetCardResourceAllocation ResourceAllocation
		{
			get
			{
				return this._resourceAllocation;
			}
			set
			{
				this._resourceAllocation = value;
			}
		}
		public string ExternalId
		{
			get
			{
				return this._externalId;
			}
			set
			{
				this._externalId = value;
			}
		}
		public bool? UptCompatibilityEnabled
		{
			get
			{
				return this._uptCompatibilityEnabled;
			}
			set
			{
				this._uptCompatibilityEnabled = value;
			}
		}
	}
}
