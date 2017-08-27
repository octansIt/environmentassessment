namespace EnvironmentAssessment.Common.VimApi
{
	public class GatewayToHostConnectFault : GatewayConnectFault
	{
		protected string _hostname;
		protected int? _port;
		public string Hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				this._hostname = value;
			}
		}
		public int? Port
		{
			get
			{
				return this._port;
			}
			set
			{
				this._port = value;
			}
		}
	}
}
