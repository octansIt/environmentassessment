namespace EnvironmentAssessment.Common.VimApi
{
	public class GlobalMessageChangedEvent : SessionEvent
	{
		protected string _message;
		protected string _prevMessage;
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
		public string PrevMessage
		{
			get
			{
				return this._prevMessage;
			}
			set
			{
				this._prevMessage = value;
			}
		}
	}
}
