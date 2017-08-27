namespace EnvironmentAssessment.Common.VimApi
{
	public class SendEmailAction : Action
	{
		protected string _toList;
		protected string _ccList;
		protected string _subject;
		protected string _body;
		public string ToList
		{
			get
			{
				return this._toList;
			}
			set
			{
				this._toList = value;
			}
		}
		public string CcList
		{
			get
			{
				return this._ccList;
			}
			set
			{
				this._ccList = value;
			}
		}
		public string Subject
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
		public string Body
		{
			get
			{
				return this._body;
			}
			set
			{
				this._body = value;
			}
		}
	}
}
