namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfElement : OvfInvalidPackage
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
