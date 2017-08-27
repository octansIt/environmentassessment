namespace EnvironmentAssessment.Common.VimApi
{
	public class VmTimedoutStartingSecondaryEvent : VmEvent
	{
		protected long? _timeout;
		public long? Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				this._timeout = value;
			}
		}
	}
}
