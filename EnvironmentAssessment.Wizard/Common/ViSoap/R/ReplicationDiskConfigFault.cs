namespace EnvironmentAssessment.Common.VISoap
{
    public class ReplicationDiskConfigFault : ReplicationConfigFault
	{
		protected string _reason;
		protected ManagedObjectReference _vmRef;
		protected int? _key;
		protected ReplicationDiskConfigFault_LinkedView _linkedView;
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
		public int? Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public ReplicationDiskConfigFault_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
