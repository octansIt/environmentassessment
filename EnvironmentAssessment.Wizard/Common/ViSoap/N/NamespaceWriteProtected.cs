namespace EnvironmentAssessment.Common.VISoap
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
