namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfXmlFormat : OvfInvalidPackage
	{
		protected string _description;
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
