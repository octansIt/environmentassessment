namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerPowerOnFault : InvalidState
	{
		protected string _extensionKey;
		protected string _extensionName;
		protected string _description;
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
