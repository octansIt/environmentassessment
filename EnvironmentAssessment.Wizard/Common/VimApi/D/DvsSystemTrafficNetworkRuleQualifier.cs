namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsSystemTrafficNetworkRuleQualifier : DvsNetworkRuleQualifier
	{
		protected StringExpression _typeOfSystemTraffic;
		public StringExpression TypeOfSystemTraffic
		{
			get
			{
				return this._typeOfSystemTraffic;
			}
			set
			{
				this._typeOfSystemTraffic = value;
			}
		}
	}
}
