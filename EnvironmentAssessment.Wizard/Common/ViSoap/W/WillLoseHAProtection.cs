namespace EnvironmentAssessment.Common.VISoap
{
    public class WillLoseHAProtection : MigrationFault
	{
		protected string _resolution;
		public string Resolution
		{
			get
			{
				return this._resolution;
			}
			set
			{
				this._resolution = value;
			}
		}
	}
}
