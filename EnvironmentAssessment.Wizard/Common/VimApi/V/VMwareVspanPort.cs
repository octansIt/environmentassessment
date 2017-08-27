namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareVspanPort : DynamicData
	{
		protected string[] _portKey;
		protected string[] _uplinkPortName;
		protected string[] _wildcardPortConnecteeType;
		protected int[] _vlans;
		protected string[] _ipAddress;
		public string[] PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
		public string[] UplinkPortName
		{
			get
			{
				return this._uplinkPortName;
			}
			set
			{
				this._uplinkPortName = value;
			}
		}
		public string[] WildcardPortConnecteeType
		{
			get
			{
				return this._wildcardPortConnecteeType;
			}
			set
			{
				this._wildcardPortConnecteeType = value;
			}
		}
		public int[] Vlans
		{
			get
			{
				return this._vlans;
			}
			set
			{
				this._vlans = value;
			}
		}
		public string[] IpAddress
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
