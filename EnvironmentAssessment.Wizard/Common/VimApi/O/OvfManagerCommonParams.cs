namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfManagerCommonParams : DynamicData
	{
		protected string _locale;
		protected string _deploymentOption;
		protected KeyValue[] _msgBundle;
		protected string[] _importOption;
		public string Locale
		{
			get
			{
				return this._locale;
			}
			set
			{
				this._locale = value;
			}
		}
		public string DeploymentOption
		{
			get
			{
				return this._deploymentOption;
			}
			set
			{
				this._deploymentOption = value;
			}
		}
		public KeyValue[] MsgBundle
		{
			get
			{
				return this._msgBundle;
			}
			set
			{
				this._msgBundle = value;
			}
		}
		public string[] ImportOption
		{
			get
			{
				return this._importOption;
			}
			set
			{
				this._importOption = value;
			}
		}
	}
}
