namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostClusterStatusState : DynamicData
	{
		protected string _state;
		protected VsanHostClusterStatusStateCompletionEstimate _completion;
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public VsanHostClusterStatusStateCompletionEstimate Completion
		{
			get
			{
				return this._completion;
			}
			set
			{
				this._completion = value;
			}
		}
	}
}
