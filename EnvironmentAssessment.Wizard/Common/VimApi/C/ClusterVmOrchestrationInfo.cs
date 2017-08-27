namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterVmOrchestrationInfo : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected ClusterVmReadiness _vmReadiness;
		protected ClusterVmOrchestrationInfo_LinkedView _linkedView;
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
		public ClusterVmReadiness VmReadiness
		{
			get
			{
				return this._vmReadiness;
			}
			set
			{
				this._vmReadiness = value;
			}
		}
		public ClusterVmOrchestrationInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
