namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoManagerKmipServerStatus : DynamicData
	{
		protected string _name;
		protected ManagedEntityStatus _status;
		protected string _connectionStatus;
		protected CryptoManagerKmipCertificateInfo _certInfo;
		protected bool? _clientTrustServer;
		protected bool? _serverTrustClient;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public ManagedEntityStatus Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public string ConnectionStatus
		{
			get
			{
				return this._connectionStatus;
			}
			set
			{
				this._connectionStatus = value;
			}
		}
		public CryptoManagerKmipCertificateInfo CertInfo
		{
			get
			{
				return this._certInfo;
			}
			set
			{
				this._certInfo = value;
			}
		}
		public bool? ClientTrustServer
		{
			get
			{
				return this._clientTrustServer;
			}
			set
			{
				this._clientTrustServer = value;
			}
		}
		public bool? ServerTrustClient
		{
			get
			{
				return this._serverTrustClient;
			}
			set
			{
				this._serverTrustClient = value;
			}
		}
	}
}
