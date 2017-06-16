namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterNotAttemptedVmInfo : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected LocalizedMethodFault _fault;
		protected ClusterNotAttemptedVmInfo_LinkedView _linkedView;
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
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
		public ClusterNotAttemptedVmInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
