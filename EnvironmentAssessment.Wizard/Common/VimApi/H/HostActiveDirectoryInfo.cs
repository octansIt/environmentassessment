namespace EnvironmentAssessment.Common.VimApi
{
	public class HostActiveDirectoryInfo : HostDirectoryStoreInfo
	{
		protected string _joinedDomain;
		protected string[] _trustedDomain;
		protected string _domainMembershipStatus;
		protected bool? _smartCardAuthenticationEnabled;
		public string JoinedDomain
		{
			get
			{
				return this._joinedDomain;
			}
			set
			{
				this._joinedDomain = value;
			}
		}
		public string[] TrustedDomain
		{
			get
			{
				return this._trustedDomain;
			}
			set
			{
				this._trustedDomain = value;
			}
		}
		public string DomainMembershipStatus
		{
			get
			{
				return this._domainMembershipStatus;
			}
			set
			{
				this._domainMembershipStatus = value;
			}
		}
		public bool? SmartCardAuthenticationEnabled
		{
			get
			{
				return this._smartCardAuthenticationEnabled;
			}
			set
			{
				this._smartCardAuthenticationEnabled = value;
			}
		}
	}
}
