namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidDasConfigArgument : InvalidArgument
	{
		protected string _entry;
		protected string _clusterName;
		public string Entry
		{
			get
			{
				return this._entry;
			}
			set
			{
				this._entry = value;
			}
		}
		public string ClusterName
		{
			get
			{
				return this._clusterName;
			}
			set
			{
				this._clusterName = value;
			}
		}
	}
}
