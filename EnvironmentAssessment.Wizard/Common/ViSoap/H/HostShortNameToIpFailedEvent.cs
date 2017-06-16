namespace EnvironmentAssessment.Common.VISoap
{
    public class HostShortNameToIpFailedEvent : HostEvent
	{
		protected string _shortName;
		public string ShortName
		{
			get
			{
				return this._shortName;
			}
			set
			{
				this._shortName = value;
			}
		}
	}
}
