namespace EnvironmentAssessment.Common.VimApi
{
	public class NamespaceWriteProtected : VimFault
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
