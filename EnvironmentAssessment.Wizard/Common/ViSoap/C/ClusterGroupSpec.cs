namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterGroupSpec : ArrayUpdateSpec
	{
		protected ClusterGroupInfo _info;
		public ClusterGroupInfo Info
		{
			get
			{
				return this._info;
			}
			set
			{
				this._info = value;
			}
		}
	}
}
