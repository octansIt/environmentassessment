namespace EnvironmentAssessment.Common.VimApi
{
	public class CryptoManagerKmipServerCertInfo : DynamicData
	{
		protected string _certificate;
		protected CryptoManagerKmipCertificateInfo _certInfo;
		protected bool? _clientTrustServer;
		public string Certificate
		{
			get
			{
				return this._certificate;
			}
			set
			{
				this._certificate = value;
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
	}
}
