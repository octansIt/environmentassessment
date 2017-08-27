namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileApplyProfileElement : ApplyProfile
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
