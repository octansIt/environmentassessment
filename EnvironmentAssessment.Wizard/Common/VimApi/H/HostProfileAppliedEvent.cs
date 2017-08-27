namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProfileAppliedEvent : HostEvent
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
