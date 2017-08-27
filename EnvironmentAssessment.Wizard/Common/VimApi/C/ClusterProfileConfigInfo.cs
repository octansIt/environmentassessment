namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterProfileConfigInfo : ProfileConfigInfo
	{
		protected ComplianceProfile _complyProfile;
		public ComplianceProfile ComplyProfile
		{
			get
			{
				return this._complyProfile;
			}
			set
			{
				this._complyProfile = value;
			}
		}
	}
}
