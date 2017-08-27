namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfConsumerValidationFault : VmConfigFault
	{
		protected string _extensionKey;
		protected string _extensionName;
		protected string _message;
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
		public string Message
		{
			get
			{
				return this._message;
			}
			set
			{
				this._message = value;
			}
		}
	}
}
