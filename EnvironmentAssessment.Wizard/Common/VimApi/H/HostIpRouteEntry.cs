namespace EnvironmentAssessment.Common.VimApi
{
	public class HostIpRouteEntry : DynamicData
	{
		protected string _network;
		protected int _prefixLength;
		protected string _gateway;
		protected string _deviceName;
		public string Network
		{
			get
			{
				return this._network;
			}
			set
			{
				this._network = value;
			}
		}
		public int PrefixLength
		{
			get
			{
				return this._prefixLength;
			}
			set
			{
				this._prefixLength = value;
			}
		}
		public string Gateway
		{
			get
			{
				return this._gateway;
			}
			set
			{
				this._gateway = value;
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
