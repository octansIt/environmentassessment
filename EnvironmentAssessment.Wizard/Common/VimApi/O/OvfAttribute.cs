namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfAttribute : OvfInvalidPackage
	{
		protected string _elementName;
		protected string _attributeName;
		public string ElementName
		{
			get
			{
				return this._elementName;
			}
			set
			{
				this._elementName = value;
			}
		}
		public string AttributeName
		{
			get
			{
				return this._attributeName;
			}
			set
			{
				this._attributeName = value;
			}
		}
	}
}
