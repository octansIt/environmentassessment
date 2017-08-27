namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterProfileCompleteConfigSpec : ClusterProfileConfigSpec
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
