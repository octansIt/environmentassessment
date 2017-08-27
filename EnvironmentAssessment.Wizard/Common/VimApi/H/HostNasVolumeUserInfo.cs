namespace EnvironmentAssessment.Common.VimApi
{
	public class HostNasVolumeUserInfo : DynamicData
	{
		protected string _user;
		public string User
		{
			get
			{
				return this._user;
			}
			set
			{
				this._user = value;
			}
		}
	}
}
