namespace EnvironmentAssessment.Common.VISoap
{
    public class VmInstanceUuidConflictEvent : VmEvent
	{
		protected VmEventArgument _conflictedVm;
		protected string _instanceUuid;
		public VmEventArgument ConflictedVm
		{
			get
			{
				return this._conflictedVm;
			}
			set
			{
				this._conflictedVm = value;
			}
		}
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
	}
}
