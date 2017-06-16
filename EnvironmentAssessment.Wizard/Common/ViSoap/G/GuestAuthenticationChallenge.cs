namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestAuthenticationChallenge : GuestOperationsFault
	{
		protected GuestAuthentication _serverChallenge;
		protected long _sessionID;
		public GuestAuthentication ServerChallenge
		{
			get
			{
				return this._serverChallenge;
			}
			set
			{
				this._serverChallenge = value;
			}
		}
		public long SessionID
		{
			get
			{
				return this._sessionID;
			}
			set
			{
				this._sessionID = value;
			}
		}
	}
}
