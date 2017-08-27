namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSnapshot_LinkedView
	{
		protected VirtualMachineSnapshot[] _childSnapshot;
		protected VirtualMachine _vm;
		public VirtualMachineSnapshot[] ChildSnapshot
		{
			get
			{
				return this._childSnapshot;
			}
		}
		public VirtualMachine Vm
		{
			get
			{
				return this._vm;
			}
		}
	}
}
