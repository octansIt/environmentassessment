namespace EnvironmentAssessment.Common.VimApi
{
	public class VmMacConflictEvent : VmEvent
	{
		protected VmEventArgument _conflictedVm;
		protected string _mac;
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
		public string Mac
		{
			get
			{
				return this._mac;
			}
			set
			{
				this._mac = value;
			}
		}
	}
}
