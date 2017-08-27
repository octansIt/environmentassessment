namespace EnvironmentAssessment.Common.VimApi
{
	public class SSPIChallenge : VimFault
	{
		protected string _base64Token;
		public string Base64Token
		{
			get
			{
				return this._base64Token;
			}
			set
			{
				this._base64Token = value;
			}
		}
	}
}
