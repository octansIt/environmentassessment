namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProxySwitchHostLagConfig : DynamicData
	{
		protected string _lagKey;
		protected string _lagName;
		protected KeyValue[] _uplinkPort;
		public string LagKey
		{
			get
			{
				return this._lagKey;
			}
			set
			{
				this._lagKey = value;
			}
		}
		public string LagName
		{
			get
			{
				return this._lagName;
			}
			set
			{
				this._lagName = value;
			}
		}
		public KeyValue[] UplinkPort
		{
			get
			{
				return this._uplinkPort;
			}
			set
			{
				this._uplinkPort = value;
			}
		}
	}
}
