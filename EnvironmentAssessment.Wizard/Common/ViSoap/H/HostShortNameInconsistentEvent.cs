namespace EnvironmentAssessment.Common.VISoap
{
    public class HostShortNameInconsistentEvent : HostDasEvent
	{
		protected string _shortName;
		protected string _shortName2;
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
		public string ShortName2
		{
			get
			{
				return this._shortName2;
			}
			set
			{
				this._shortName2 = value;
			}
		}
	}
}
