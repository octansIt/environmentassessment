namespace EnvironmentAssessment.Common.VimApi
{
	public class DasConfigFault : VimFault
	{
		protected string _reason;
		protected string _output;
		protected Event[] _event;
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
		public string Output
		{
			get
			{
				return this._output;
			}
			set
			{
				this._output = value;
			}
		}
		public Event[] Event
		{
			get
			{
				return this._event;
			}
			set
			{
				this._event = value;
			}
		}
	}
}
