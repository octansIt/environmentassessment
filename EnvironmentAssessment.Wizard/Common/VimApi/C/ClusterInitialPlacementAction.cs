namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterInitialPlacementAction : ClusterAction
	{
		protected ManagedObjectReference _targetHost;
		protected ManagedObjectReference _pool;
		protected ClusterInitialPlacementAction_LinkedView _linkedView;
		public ManagedObjectReference TargetHost
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
		public ManagedObjectReference Pool
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
		public ClusterInitialPlacementAction_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
