namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDrsVmConfigSpec : ArrayUpdateSpec
	{
		protected ClusterDrsVmConfigInfo _info;
		public ClusterDrsVmConfigInfo Info
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
