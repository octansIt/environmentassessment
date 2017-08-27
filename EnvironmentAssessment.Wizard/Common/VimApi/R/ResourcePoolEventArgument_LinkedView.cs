namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolEventArgument_LinkedView
	{
		protected ResourcePool _resourcePool;
		public ResourcePool ResourcePool
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
	}
}
