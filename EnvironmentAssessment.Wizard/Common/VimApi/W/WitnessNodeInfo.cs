namespace EnvironmentAssessment.Common.VimApi
{
	public class WitnessNodeInfo : DynamicData
	{
		protected CustomizationIPSettings _ipSettings;
		protected string _biosUuid;
		public CustomizationIPSettings IpSettings
		{
			get
			{
				return this._ipSettings;
			}
			set
			{
				this._ipSettings = value;
			}
		}
		public string BiosUuid
		{
			get
			{
				return this._biosUuid;
			}
			set
			{
				this._biosUuid = value;
			}
		}
	}
}
