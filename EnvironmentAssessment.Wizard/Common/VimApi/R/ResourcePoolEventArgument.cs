namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _resourcePool;
		protected ResourcePoolEventArgument_LinkedView _linkedView;
		public ManagedObjectReference ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
			set
			{
				this._resourcePool = value;
			}
		}
		public ResourcePoolEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
