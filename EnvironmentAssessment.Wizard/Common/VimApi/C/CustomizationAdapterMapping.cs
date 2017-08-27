namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomizationAdapterMapping : DynamicData
	{
		protected string _macAddress;
		protected CustomizationIPSettings _adapter;
		public string MacAddress
		{
			get
			{
				return this._macAddress;
			}
			set
			{
				this._macAddress = value;
			}
		}
		public CustomizationIPSettings Adapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				this._adapter = value;
			}
		}
	}
}
