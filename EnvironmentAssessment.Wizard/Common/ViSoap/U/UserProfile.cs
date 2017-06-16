namespace EnvironmentAssessment.Common.VISoap
{
    public class UserProfile : ApplyProfile
	{
		protected string _key;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
	}
}
