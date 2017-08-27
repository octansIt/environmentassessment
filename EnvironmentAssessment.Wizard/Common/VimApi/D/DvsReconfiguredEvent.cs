namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsReconfiguredEvent : DvsEvent
	{
		protected DVSConfigSpec _configSpec;
		protected ChangesInfoEventArgument _configChanges;
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
		public ChangesInfoEventArgument ConfigChanges
		{
			get
			{
				return this._configChanges;
			}
			set
			{
				this._configChanges = value;
			}
		}
	}
}
