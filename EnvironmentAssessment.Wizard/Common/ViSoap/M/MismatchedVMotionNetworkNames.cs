namespace EnvironmentAssessment.Common.VISoap
{
    public class MismatchedVMotionNetworkNames : MigrationFault
	{
		protected string _sourceNetwork;
		protected string _destNetwork;
		public string SourceNetwork
		{
			get
			{
				return this._sourceNetwork;
			}
			set
			{
				this._sourceNetwork = value;
			}
		}
		public string DestNetwork
		{
			get
			{
				return this._destNetwork;
			}
			set
			{
				this._destNetwork = value;
			}
		}
	}
}
