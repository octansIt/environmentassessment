namespace EnvironmentAssessment.Common.VISoap
{
    public class VmClonedEvent : VmCloneEvent
	{
		protected VmEventArgument _sourceVm;
		public VmEventArgument SourceVm
		{
			get
			{
				return this._sourceVm;
			}
			set
			{
				this._sourceVm = value;
			}
		}
	}
}
