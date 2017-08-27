namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileConfigInfo : ProfileConfigInfo
	{
		protected HostApplyProfile _applyProfile;
		protected ComplianceProfile _defaultComplyProfile;
		protected ComplianceLocator[] _defaultComplyLocator;
		protected ComplianceProfile _customComplyProfile;
		protected string[] _disabledExpressionList;
		protected ProfileDescription _description;
		public HostApplyProfile ApplyProfile
		{
			get
			{
				return this._applyProfile;
			}
			set
			{
				this._applyProfile = value;
			}
		}
		public ComplianceProfile DefaultComplyProfile
		{
			get
			{
				return this._defaultComplyProfile;
			}
			set
			{
				this._defaultComplyProfile = value;
			}
		}
		public ComplianceLocator[] DefaultComplyLocator
		{
			get
			{
				return this._defaultComplyLocator;
			}
			set
			{
				this._defaultComplyLocator = value;
			}
		}
		public ComplianceProfile CustomComplyProfile
		{
			get
			{
				return this._customComplyProfile;
			}
			set
			{
				this._customComplyProfile = value;
			}
		}
		public string[] DisabledExpressionList
		{
			get
			{
				return this._disabledExpressionList;
			}
			set
			{
				this._disabledExpressionList = value;
			}
		}
		public ProfileDescription Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
