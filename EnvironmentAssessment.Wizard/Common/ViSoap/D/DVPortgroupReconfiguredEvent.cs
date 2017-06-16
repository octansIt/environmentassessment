namespace EnvironmentAssessment.Common.VISoap
{
    public class DVPortgroupReconfiguredEvent : DVPortgroupEvent
	{
		protected DVPortgroupConfigSpec _configSpec;
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
	}
}
