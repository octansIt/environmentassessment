namespace EnvironmentAssessment.Common.VimApi
{
	public class SessionManagerHttpServiceRequestSpec : SessionManagerServiceRequestSpec
	{
		protected string _method;
		protected string _url;
		public string Method
		{
			get
			{
				return this._method;
			}
			set
			{
				this._method = value;
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
	}
}
