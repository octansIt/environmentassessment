namespace EnvironmentAssessment.Common.VimApi
{
	public class NetIpStackInfoNetToMedia : DynamicData
	{
		protected string _ipAddress;
		protected string _physicalAddress;
		protected string _device;
		protected string _type;
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
		public string PhysicalAddress
		{
			get
			{
				return this._physicalAddress;
			}
			set
			{
				this._physicalAddress = value;
			}
		}
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
	}
}
