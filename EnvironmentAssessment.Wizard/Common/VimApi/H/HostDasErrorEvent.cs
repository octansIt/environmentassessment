namespace EnvironmentAssessment.Common.VimApi
{
	public class HostDasErrorEvent : HostEvent
	{
		protected string _message;
		protected string _reason;
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
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}
