namespace EnvironmentAssessment.Common.VimApi
{
	public class HostPciDevice : DynamicData
	{
		protected string _id;
		protected short _classId;
		protected sbyte _bus;
		protected sbyte _slot;
		protected sbyte _function;
		protected short _vendorId;
		protected short _subVendorId;
		protected string _vendorName;
		protected short _deviceId;
		protected short _subDeviceId;
		protected string _parentBridge;
		protected string _deviceName;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public short ClassId
		{
			get
			{
				return this._classId;
			}
			set
			{
				this._classId = value;
			}
		}
		public sbyte Bus
		{
			get
			{
				return this._bus;
			}
			set
			{
				this._bus = value;
			}
		}
		public sbyte Slot
		{
			get
			{
				return this._slot;
			}
			set
			{
				this._slot = value;
			}
		}
		public sbyte Function
		{
			get
			{
				return this._function;
			}
			set
			{
				this._function = value;
			}
		}
		public short VendorId
		{
			get
			{
				return this._vendorId;
			}
			set
			{
				this._vendorId = value;
			}
		}
		public short SubVendorId
		{
			get
			{
				return this._subVendorId;
			}
			set
			{
				this._subVendorId = value;
			}
		}
		public string VendorName
		{
			get
			{
				return this._vendorName;
			}
			set
			{
				this._vendorName = value;
			}
		}
		public short DeviceId
		{
			get
			{
				return this._deviceId;
			}
			set
			{
				this._deviceId = value;
			}
		}
		public short SubDeviceId
		{
			get
			{
				return this._subDeviceId;
			}
			set
			{
				this._subDeviceId = value;
			}
		}
		public string ParentBridge
		{
			get
			{
				return this._parentBridge;
			}
			set
			{
				this._parentBridge = value;
			}
		}
		public string DeviceName
		{
			get
			{
				return this._deviceName;
			}
			set
			{
				this._deviceName = value;
			}
		}
	}
}
