namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterAttemptedVmInfo : DynamicData
	{
		protected ManagedObjectReference _vm;
		protected ManagedObjectReference _task;
		protected ClusterAttemptedVmInfo_LinkedView _linkedView;
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
		public ManagedObjectReference Task
		{
			get
			{
				return this._task;
			}
			set
			{
				this._task = value;
			}
		}
		public ClusterAttemptedVmInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
