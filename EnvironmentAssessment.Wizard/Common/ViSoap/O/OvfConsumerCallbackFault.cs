namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfConsumerCallbackFault : OvfFault
	{
		protected string _extensionKey;
		protected string _extensionName;
		public string ExtensionKey
		{
			get
			{
				return this._extensionKey;
			}
			set
			{
				this._extensionKey = value;
			}
		}
		public string ExtensionName
		{
			get
			{
				return this._extensionName;
			}
			set
			{
				this._extensionName = value;
			}
		}
	}
}
