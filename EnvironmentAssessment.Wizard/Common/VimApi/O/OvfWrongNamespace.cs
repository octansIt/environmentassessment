namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfWrongNamespace : OvfInvalidPackage
	{
		protected string _namespaceName;
		public string NamespaceName
		{
			get
			{
				return this._namespaceName;
			}
			set
			{
				this._namespaceName = value;
			}
		}
	}
}
