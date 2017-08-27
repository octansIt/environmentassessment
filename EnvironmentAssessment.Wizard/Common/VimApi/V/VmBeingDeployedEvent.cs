namespace EnvironmentAssessment.Common.VimApi
{
	public class VmBeingDeployedEvent : VmEvent
	{
		protected VmEventArgument _srcTemplate;
		public VmEventArgument SrcTemplate
		{
			get
			{
				return this._srcTemplate;
			}
			set
			{
				this._srcTemplate = value;
			}
		}
	}
}
