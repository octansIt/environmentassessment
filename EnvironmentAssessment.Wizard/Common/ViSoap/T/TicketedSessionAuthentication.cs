namespace EnvironmentAssessment.Common.VISoap
{
    public class TicketedSessionAuthentication : GuestAuthentication
	{
		protected string _ticket;
		public string Ticket
		{
			get
			{
				return this._ticket;
			}
			set
			{
				this._ticket = value;
			}
		}
	}
}
