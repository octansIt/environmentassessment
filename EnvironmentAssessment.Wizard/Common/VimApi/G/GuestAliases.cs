namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestAliases : DynamicData
	{
		protected string _base64Cert;
		protected GuestAuthAliasInfo[] _aliases;
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
		public GuestAuthAliasInfo[] Aliases
		{
			get
			{
				return this._aliases;
			}
			set
			{
				this._aliases = value;
			}
		}
	}
}
