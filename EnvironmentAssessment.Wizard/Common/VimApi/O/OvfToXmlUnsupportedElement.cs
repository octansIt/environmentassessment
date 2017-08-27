namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfToXmlUnsupportedElement : OvfSystemFault
	{
		protected string _name;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
	}
}
