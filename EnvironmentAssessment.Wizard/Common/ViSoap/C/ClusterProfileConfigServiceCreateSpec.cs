namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterProfileConfigServiceCreateSpec : ClusterProfileConfigSpec
	{
		protected string[] _serviceType;
		public string[] ServiceType
		{
			get
			{
				return this._serviceType;
			}
			set
			{
				this._serviceType = value;
			}
		}
	}
}
