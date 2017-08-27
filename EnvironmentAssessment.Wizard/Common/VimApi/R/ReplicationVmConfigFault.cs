namespace EnvironmentAssessment.Common.VimApi
{
	public class ReplicationVmConfigFault : ReplicationConfigFault
	{
		protected string _reason;
		protected ManagedObjectReference _vmRef;
		protected ReplicationVmConfigFault_LinkedView _linkedView;
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public ManagedObjectReference VmRef
		{
			get
			{
				return this._vmRef;
			}
			set
			{
				this._vmRef = value;
			}
		}
		public ReplicationVmConfigFault_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
