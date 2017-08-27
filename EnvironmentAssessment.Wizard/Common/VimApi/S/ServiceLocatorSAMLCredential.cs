namespace EnvironmentAssessment.Common.VimApi
{
	public class ServiceLocatorSAMLCredential : ServiceLocatorCredential
	{
		protected string _token;
		public string Token
		{
			get
			{
				return this._token;
			}
			set
			{
				this._token = value;
			}
		}
	}
}
