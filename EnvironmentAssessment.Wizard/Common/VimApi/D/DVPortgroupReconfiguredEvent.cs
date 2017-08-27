namespace EnvironmentAssessment.Common.VimApi
{
	public class DVPortgroupReconfiguredEvent : DVPortgroupEvent
	{
		protected DVPortgroupConfigSpec _configSpec;
		protected ChangesInfoEventArgument _configChanges;
		public DVPortgroupConfigSpec ConfigSpec
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
