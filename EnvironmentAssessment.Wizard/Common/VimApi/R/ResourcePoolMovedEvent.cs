namespace EnvironmentAssessment.Common.VimApi
{
	public class ResourcePoolMovedEvent : ResourcePoolEvent
	{
		protected ResourcePoolEventArgument _oldParent;
		protected ResourcePoolEventArgument _newParent;
		public ResourcePoolEventArgument OldParent
		{
			get
			{
				return this._oldParent;
			}
			set
			{
				this._oldParent = value;
			}
		}
		public ResourcePoolEventArgument NewParent
		{
			get
			{
				return this._newParent;
			}
			set
			{
				this._newParent = value;
			}
		}
	}
}
