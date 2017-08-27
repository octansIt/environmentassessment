namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterComplianceCheckedEvent : ClusterEvent
	{
		protected ProfileEventArgument _profile;
		public ProfileEventArgument Profile
		{
			get
			{
				return this._profile;
			}
			set
			{
				this._profile = value;
			}
		}
	}
}
