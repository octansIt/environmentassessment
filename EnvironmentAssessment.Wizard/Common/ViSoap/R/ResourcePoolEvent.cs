namespace EnvironmentAssessment.Common.VISoap
{
    public class ResourcePoolEvent : Event
	{
		protected ResourcePoolEventArgument _resourcePool;
		public ResourcePoolEventArgument ResourcePool
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
