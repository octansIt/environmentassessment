namespace EnvironmentAssessment.Common.VISoap
{
    public class NetworksMayNotBeTheSame : MigrationFault
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
