namespace EnvironmentAssessment.Common.VimApi
{
	public class HostServiceTicket : DynamicData
	{
		protected string _host;
		protected int? _port;
		protected string _sslThumbprint;
		protected string _service;
		protected string _serviceVersion;
		protected string _sessionId;
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
		public string Service
		{
			get
			{
				return this._service;
			}
			set
			{
				this._service = value;
			}
		}
		public string ServiceVersion
		{
			get
			{
				return this._serviceVersion;
			}
			set
			{
				this._serviceVersion = value;
			}
		}
		public string SessionId
		{
			get
			{
				return this._sessionId;
			}
			set
			{
				this._sessionId = value;
			}
		}
	}
}
