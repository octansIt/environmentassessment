namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualPCIPassthroughDeviceBackingInfo : VirtualDeviceDeviceBackingInfo
	{
		protected string _id;
		protected string _deviceId;
		protected string _systemId;
		protected short _vendorId;
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
		public string DeviceId
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
		public string SystemId
		{
			get
			{
				return this._systemId;
			}
			set
			{
				this._systemId = value;
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
	}
}
