namespace EnvironmentAssessment.Common.VimApi
{
	public class GeneralEvent : Event
	{
		protected string _message;
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
	}
}
