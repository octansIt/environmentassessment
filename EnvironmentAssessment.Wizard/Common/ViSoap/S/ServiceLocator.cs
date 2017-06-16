namespace EnvironmentAssessment.Common.VISoap
{
    public class ServiceLocator : DynamicData
	{
		protected string _instanceUuid;
		protected string _url;
		protected ServiceLocatorCredential _credential;
		protected string _sslThumbprint;
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
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
		public ServiceLocatorCredential Credential
		{
			get
			{
				return this._credential;
			}
			set
			{
				this._credential = value;
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
