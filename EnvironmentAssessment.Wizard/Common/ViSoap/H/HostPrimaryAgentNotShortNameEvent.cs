namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPrimaryAgentNotShortNameEvent : HostDasEvent
	{
		protected string _primaryAgent;
		public string PrimaryAgent
		{
			get
			{
				return this._primaryAgent;
			}
			set
			{
				this._primaryAgent = value;
			}
		}
	}
}
