namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSslThumbprintInfo : DynamicData
	{
		protected string _principal;
		protected string _ownerTag;
		protected string[] _sslThumbprints;
		public string Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				this._principal = value;
			}
		}
		public string OwnerTag
		{
			get
			{
				return this._ownerTag;
			}
			set
			{
				this._ownerTag = value;
			}
		}
		public string[] SslThumbprints
		{
			get
			{
				return this._sslThumbprints;
			}
			set
			{
				this._sslThumbprints = value;
			}
		}
	}
}
