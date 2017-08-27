namespace EnvironmentAssessment.Common.VimApi
{
	public class VmUnsupportedStartingEvent : VmStartingEvent
	{
		protected string _guestId;
		public string GuestId
		{
			get
			{
				return this._guestId;
			}
			set
			{
				this._guestId = value;
			}
		}
	}
}
