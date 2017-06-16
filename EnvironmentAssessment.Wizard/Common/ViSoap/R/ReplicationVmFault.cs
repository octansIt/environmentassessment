namespace EnvironmentAssessment.Common.VISoap
{
    public class ReplicationVmFault : ReplicationFault
	{
		protected string _reason;
		protected string _state;
		protected string _instanceId;
		protected ManagedObjectReference _vm;
		protected ReplicationVmFault_LinkedView _linkedView;
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
		public string InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				this._instanceId = value;
			}
		}
		public ManagedObjectReference Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public ReplicationVmFault_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
