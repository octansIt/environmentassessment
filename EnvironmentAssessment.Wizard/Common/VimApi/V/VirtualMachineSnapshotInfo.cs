namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSnapshotInfo : DynamicData
	{
		protected ManagedObjectReference _currentSnapshot;
		protected VirtualMachineSnapshotTree[] _rootSnapshotList;
		protected VirtualMachineSnapshotInfo_LinkedView _linkedView;
		public ManagedObjectReference CurrentSnapshot
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
		public VirtualMachineSnapshotTree[] RootSnapshotList
		{
			get
			{
				return this._rootSnapshotList;
			}
			set
			{
				this._rootSnapshotList = value;
			}
		}
		public VirtualMachineSnapshotInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
