namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionOvfConsumerInfo : DynamicData
	{
		protected string _callbackUrl;
		protected string[] _sectionType;
		public string CallbackUrl
		{
			get
			{
				return this._callbackUrl;
			}
			set
			{
				this._callbackUrl = value;
			}
		}
		public string[] SectionType
		{
			get
			{
				return this._sectionType;
			}
			set
			{
				this._sectionType = value;
			}
		}
	}
}
