namespace EnvironmentAssessment.Common.VISoap
{
    public class MigrationNotReady : MigrationFault
	{
		protected string _reason;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
	}
}