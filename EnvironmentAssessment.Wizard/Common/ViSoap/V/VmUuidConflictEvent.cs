namespace EnvironmentAssessment.Common.VISoap
{
    public class VmUuidConflictEvent : VmEvent
	{
		protected VmEventArgument _conflictedVm;
		protected string _uuid;
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
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
	}
}
