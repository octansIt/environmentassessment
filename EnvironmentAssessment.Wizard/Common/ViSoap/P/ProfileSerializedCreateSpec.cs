namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileSerializedCreateSpec : ProfileCreateSpec
	{
		protected string _profileConfigString;
		public string ProfileConfigString
		{
			get
			{
				return this._profileConfigString;
			}
			set
			{
				this._profileConfigString = value;
			}
		}
	}
}
