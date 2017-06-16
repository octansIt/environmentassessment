namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfUnsupportedElement : OvfUnsupportedPackage
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
