namespace EnvironmentAssessment.Common.VimApi
{
	public class HttpNfcLeaseHostInfo : DynamicData
	{
		protected string _url;
		protected string _sslThumbprint;
		public string Url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
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
