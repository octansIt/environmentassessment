namespace EnvironmentAssessment.Common.VISoap
{
    public class HostWwnConflictEvent : HostEvent
	{
		protected VmEventArgument[] _conflictedVms;
		protected HostEventArgument[] _conflictedHosts;
		protected long _wwn;
		public VmEventArgument[] ConflictedVms
		{
			get
			{
				return this._conflictedVms;
			}
			set
			{
				this._conflictedVms = value;
			}
		}
		public HostEventArgument[] ConflictedHosts
		{
			get
			{
				return this._conflictedHosts;
			}
			set
			{
				this._conflictedHosts = value;
			}
		}
		public long Wwn
		{
			get
			{
				return this._wwn;
			}
			set
			{
				this._wwn = value;
			}
		}
	}
}
