namespace EnvironmentAssessment.Common.VimApi
{
	public class ExtendedDescription : Description
	{
		protected string _messageCatalogKeyPrefix;
		protected KeyAnyValue[] _messageArg;
		public string MessageCatalogKeyPrefix
		{
			get
			{
				return this._messageCatalogKeyPrefix;
			}
			set
			{
				this._messageCatalogKeyPrefix = value;
			}
		}
		public KeyAnyValue[] MessageArg
		{
			get
			{
				return this._messageArg;
			}
			set
			{
				this._messageArg = value;
			}
		}
	}
}
