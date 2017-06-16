namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualMachineSnapshotInfo_LinkedView
	{
		protected VirtualMachineSnapshot _currentSnapshot;
		public VirtualMachineSnapshot CurrentSnapshot
		{
			get
			{
				return this._currentSnapshot;
			}
			set
			{
				this._currentSnapshot = value;
			}
		}
	}
}
