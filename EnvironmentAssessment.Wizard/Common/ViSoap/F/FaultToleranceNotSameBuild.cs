namespace EnvironmentAssessment.Common.VISoap
{
    public class FaultToleranceNotSameBuild : MigrationFault
	{
		protected string _build;
		public string Build
		{
			get
			{
				return this._build;
			}
			set
			{
				this._build = value;
			}
		}
	}
}
