namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomizationIdentification : DynamicData
	{
		protected string _joinWorkgroup;
		protected string _joinDomain;
		protected string _domainAdmin;
		protected CustomizationPassword _domainAdminPassword;
		public string JoinWorkgroup
		{
			get
			{
				return this._joinWorkgroup;
			}
			set
			{
				this._joinWorkgroup = value;
			}
		}
		public string JoinDomain
		{
			get
			{
				return this._joinDomain;
			}
			set
			{
				this._joinDomain = value;
			}
		}
		public string DomainAdmin
		{
			get
			{
				return this._domainAdmin;
			}
			set
			{
				this._domainAdmin = value;
			}
		}
		public CustomizationPassword DomainAdminPassword
		{
			get
			{
				return this._domainAdminPassword;
			}
			set
			{
				this._domainAdminPassword = value;
			}
		}
	}
}
