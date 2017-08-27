namespace EnvironmentAssessment.Common.VimApi
{
	public class LinkDiscoveryProtocolConfig : DynamicData
	{
		protected string _protocol;
		protected string _operation;
		public string Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
	}
}
