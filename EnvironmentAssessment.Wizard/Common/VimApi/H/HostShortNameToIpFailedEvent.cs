namespace EnvironmentAssessment.Common.VimApi
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
