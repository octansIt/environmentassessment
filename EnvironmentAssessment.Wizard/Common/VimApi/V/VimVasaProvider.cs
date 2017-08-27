namespace EnvironmentAssessment.Common.VimApi
{
	public class VimVasaProvider : DynamicData
	{
		protected string _url;
		protected string _name;
		protected string _selfSignedCertificate;
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
		public string SelfSignedCertificate
		{
			get
			{
				return this._selfSignedCertificate;
			}
			set
			{
				this._selfSignedCertificate = value;
			}
		}
	}
}
