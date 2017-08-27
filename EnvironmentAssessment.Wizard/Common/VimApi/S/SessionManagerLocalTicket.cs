namespace EnvironmentAssessment.Common.VimApi
{
	public class SessionManagerLocalTicket : DynamicData
	{
		protected string _userName;
		protected string _passwordFilePath;
		public string UserName
		{
			get
			{
				return this._userName;
			}
			set
			{
				this._userName = value;
			}
		}
		public string PasswordFilePath
		{
			get
			{
				return this._passwordFilePath;
			}
			set
			{
				this._passwordFilePath = value;
			}
		}
	}
}
