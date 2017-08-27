namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfDeploymentOption : DynamicData
	{
		protected string _key;
		protected string _label;
		protected string _description;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Label
		{
			get
			{
				return this._label;
			}
			set
			{
				this._label = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
