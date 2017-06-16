namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtendedElementDescription : ElementDescription
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
