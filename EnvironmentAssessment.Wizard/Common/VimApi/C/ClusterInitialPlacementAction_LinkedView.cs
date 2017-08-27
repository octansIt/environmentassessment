namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterInitialPlacementAction_LinkedView
	{
		protected HostSystem _targetHost;
		protected ResourcePool _pool;
		public HostSystem TargetHost
		{
			get
			{
				return this._targetHost;
			}
			set
			{
				this._targetHost = value;
			}
		}
		public ResourcePool Pool
		{
			get
			{
				return this._pool;
			}
			set
			{
				this._pool = value;
			}
		}
	}
}
