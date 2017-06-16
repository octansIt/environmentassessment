namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDpmHostConfigSpec : ArrayUpdateSpec
	{
		protected ClusterDpmHostConfigInfo _info;
		public ClusterDpmHostConfigInfo Info
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
