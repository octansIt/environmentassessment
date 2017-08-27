namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLicenseSpec : DynamicData
	{
		protected LicenseSource _source;
		protected string _editionKey;
		protected string[] _disabledFeatureKey;
		protected string[] _enabledFeatureKey;
		public LicenseSource Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public string EditionKey
		{
			get
			{
				return this._editionKey;
			}
			set
			{
				this._editionKey = value;
			}
		}
		public string[] DisabledFeatureKey
		{
			get
			{
				return this._disabledFeatureKey;
			}
			set
			{
				this._disabledFeatureKey = value;
			}
		}
		public string[] EnabledFeatureKey
		{
			get
			{
				return this._enabledFeatureKey;
			}
			set
			{
				this._enabledFeatureKey = value;
			}
		}
	}
}
