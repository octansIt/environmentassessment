namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoManagerKmipClusterStatus : DynamicData
	{
		protected KeyProviderId _clusterId;
		protected CryptoManagerKmipServerStatus[] _servers;
		protected CryptoManagerKmipCertificateInfo _clientCertInfo;
		public KeyProviderId ClusterId
		{
			get
			{
				return this._clusterId;
			}
			set
			{
				this._clusterId = value;
			}
		}
		public CryptoManagerKmipServerStatus[] Servers
		{
			get
			{
				return this._servers;
			}
			set
			{
				this._servers = value;
			}
		}
		public CryptoManagerKmipCertificateInfo ClientCertInfo
		{
			get
			{
				return this._clientCertInfo;
			}
			set
			{
				this._clientCertInfo = value;
			}
		}
	}
}
