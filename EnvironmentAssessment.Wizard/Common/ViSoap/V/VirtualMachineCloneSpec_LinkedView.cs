namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineCloneSpec_LinkedView
	{
		protected VirtualMachineSnapshot _snapshot;
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
	}
}
