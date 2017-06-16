namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineMksTicket : DynamicData
	{
		protected string _ticket;
		protected string _cfgFile;
		protected string _host;
		protected int? _port;
		protected string _sslThumbprint;
		public string Ticket
		{
			get
			{
				return this._ticket;
			}
			set
			{
				this._ticket = value;
			}
		}
		public string CfgFile
		{
			get
			{
				return this._cfgFile;
			}
			set
			{
				this._cfgFile = value;
			}
		}
		public string Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
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
		public string SslThumbprint
		{
			get
			{
				return this._sslThumbprint;
			}
			set
			{
				this._sslThumbprint = value;
			}
		}
	}
}
