namespace EnvironmentAssessment.Common.VISoap
{
    public class HostActiveDirectoryInfo : HostDirectoryStoreInfo
	{
		protected string _joinedDomain;
		protected string[] _trustedDomain;
		protected string _domainMembershipStatus;
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
	}
}
