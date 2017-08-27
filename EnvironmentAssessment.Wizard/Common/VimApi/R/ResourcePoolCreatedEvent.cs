namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolCreatedEvent : ResourcePoolEvent
	{
		protected ResourcePoolEventArgument _parent;
		public ResourcePoolEventArgument Parent
		{
			get
			{
				return this._parent;
			}
			set
			{
				this._parent = value;
			}
		}
	}
}
