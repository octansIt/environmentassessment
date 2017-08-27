namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSnapshotTree_LinkedView
	{
		protected VirtualMachineSnapshot _snapshot;
		protected VirtualMachine _vm;
		public VirtualMachineSnapshot Snapshot
		{
			get
			{
				return this._snapshot;
			}
			set
			{
				this._snapshot = value;
			}
		}
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
	}
}
