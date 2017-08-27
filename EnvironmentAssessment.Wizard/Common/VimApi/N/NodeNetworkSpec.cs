namespace EnvironmentAssessment.Common.VimApi
{
	public class NodeNetworkSpec : DynamicData
	{
		protected CustomizationIPSettings _ipSettings;
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
	}
}
