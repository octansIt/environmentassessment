namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterAttemptedVmInfo_LinkedView
	{
		protected VirtualMachine _vm;
		protected Task _task;
		public VirtualMachine Vm
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
		public Task Task
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
	}
}
