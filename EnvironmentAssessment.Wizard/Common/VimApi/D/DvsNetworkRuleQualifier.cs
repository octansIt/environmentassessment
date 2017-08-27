namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsNetworkRuleQualifier : DynamicData
	{
		protected string _key;
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
	}
}
