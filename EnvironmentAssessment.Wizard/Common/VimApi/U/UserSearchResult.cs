namespace EnvironmentAssessment.Common.VimApi
{
	public class UserSearchResult : DynamicData
	{
		protected string _principal;
		protected string _fullName;
		protected bool _group;
		public string Principal
		{
			get
			{
				return this._principal;
			}
			set
			{
				this._principal = value;
			}
		}
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
			}
		}
		public bool Group
		{
			get
			{
				return this._group;
			}
			set
			{
				this._group = value;
			}
		}
	}
}
