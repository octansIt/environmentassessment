namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestMappedAliases : DynamicData
	{
		protected string _base64Cert;
		protected string _username;
		protected GuestAuthSubject[] _subjects;
		public string Base64Cert
		{
			get
			{
				return this._base64Cert;
			}
			set
			{
				this._base64Cert = value;
			}
		}
		public string Username
		{
			get
			{
				return this._username;
			}
			set
			{
				this._username = value;
			}
		}
		public GuestAuthSubject[] Subjects
		{
			get
			{
				return this._subjects;
			}
			set
			{
				this._subjects = value;
			}
		}
	}
}
