namespace EnvironmentAssessment.Common.VISoap
{
    public class HostSyncFailedEvent : HostEvent
	{
		protected LocalizedMethodFault _reason;
		public LocalizedMethodFault Reason
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
