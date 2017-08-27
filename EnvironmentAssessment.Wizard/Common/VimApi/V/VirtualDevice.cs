namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDevice : DynamicData
	{
		protected int _key;
		protected Description _deviceInfo;
		protected VirtualDeviceBackingInfo _backing;
		protected VirtualDeviceConnectInfo _connectable;
		protected VirtualDeviceBusSlotInfo _slotInfo;
		protected int? _controllerKey;
		protected int? _unitNumber;
		public int Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public Description DeviceInfo
		{
			get
			{
				return this._deviceInfo;
			}
			set
			{
				this._deviceInfo = value;
			}
		}
		public VirtualDeviceBackingInfo Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
		public VirtualDeviceConnectInfo Connectable
		{
			get
			{
				return this._connectable;
			}
			set
			{
				this._connectable = value;
			}
		}
		public VirtualDeviceBusSlotInfo SlotInfo
		{
			get
			{
				return this._slotInfo;
			}
			set
			{
				this._slotInfo = value;
			}
		}
		public int? ControllerKey
		{
			get
			{
				return this._controllerKey;
			}
			set
			{
				this._controllerKey = value;
			}
		}
		public int? UnitNumber
		{
			get
			{
				return this._unitNumber;
			}
			set
			{
				this._unitNumber = value;
			}
		}
	}
}
