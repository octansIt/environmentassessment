namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsReconfiguredEvent : DvsEvent
	{
		protected DVSConfigSpec _configSpec;
		public DVSConfigSpec ConfigSpec
		{
			get
			{
				return this._configSpec;
			}
			set
			{
				this._configSpec = value;
			}
		}
	}
}
