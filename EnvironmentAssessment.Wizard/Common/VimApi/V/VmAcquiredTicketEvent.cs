namespace EnvironmentAssessment.Common.VimApi
{
	public class VmAcquiredTicketEvent : VmEvent
	{
		protected string _ticketType;
		public string TicketType
		{
			get
			{
				return this._ticketType;
			}
			set
			{
				this._ticketType = value;
			}
		}
	}
}
