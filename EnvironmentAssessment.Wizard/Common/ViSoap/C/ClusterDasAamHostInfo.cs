namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDasAamHostInfo : ClusterDasHostInfo
	{
		protected ClusterDasAamNodeState[] _hostDasState;
		protected string[] _primaryHosts;
		public ClusterDasAamNodeState[] HostDasState
		{
			get
			{
				return this._hostDasState;
			}
			set
			{
				this._hostDasState = value;
			}
		}
		public string[] PrimaryHosts
		{
			get
			{
				return this._primaryHosts;
			}
			set
			{
				this._primaryHosts = value;
			}
		}
	}
}
