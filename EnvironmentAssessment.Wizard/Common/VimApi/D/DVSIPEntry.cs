namespace EnvironmentAssessment.Common.VimApi
{
    public class DVSIPEntry : DynamicData
	{
		protected int? _vlanId;
		protected string _macAddress;
		protected string _ipAddress;
		public int? VlanId
		{
			get
			{
				return this._vlanId;
			}
			set
			{
				this._vlanId = value;
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
	}
}
