namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSystemIdentificationInfo : DynamicData
	{
		protected string _identifierValue;
		protected ElementDescription _identifierType;
		public string IdentifierValue
		{
			get
			{
				return this._identifierValue;
			}
			set
			{
				this._identifierValue = value;
			}
		}
		public ElementDescription IdentifierType
		{
			get
			{
				return this._identifierType;
			}
			set
			{
				this._identifierType = value;
			}
		}
	}
}
