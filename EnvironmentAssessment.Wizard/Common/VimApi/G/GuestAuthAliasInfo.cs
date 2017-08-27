namespace EnvironmentAssessment.Common.VimApi
{
	public class GuestAuthAliasInfo : DynamicData
	{
		protected GuestAuthSubject _subject;
		protected string _comment;
		public GuestAuthSubject Subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				this._subject = value;
			}
		}
		public string Comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				this._comment = value;
			}
		}
	}
}
