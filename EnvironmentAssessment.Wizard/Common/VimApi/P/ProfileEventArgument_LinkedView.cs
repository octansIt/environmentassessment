namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileEventArgument_LinkedView
	{
		protected Profile _profile;
		public Profile Profile
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
