namespace EnvironmentAssessment.Common.VISoap
{
    public class HostComplianceCheckedEvent : HostEvent
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
