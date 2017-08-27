namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchHostMemberPnicSpec : DynamicData
	{
		protected string _pnicDevice;
		protected string _uplinkPortKey;
		protected string _uplinkPortgroupKey;
		protected int? _connectionCookie;
		public string PnicDevice
		{
			get
			{
				return this._pnicDevice;
			}
			set
			{
				this._pnicDevice = value;
			}
		}
		public string UplinkPortKey
		{
			get
			{
				return this._uplinkPortKey;
			}
			set
			{
				this._uplinkPortKey = value;
			}
		}
		public string UplinkPortgroupKey
		{
			get
			{
				return this._uplinkPortgroupKey;
			}
			set
			{
				this._uplinkPortgroupKey = value;
			}
		}
		public int? ConnectionCookie
		{
			get
			{
				return this._connectionCookie;
			}
			set
			{
				this._connectionCookie = value;
			}
		}
	}
}
