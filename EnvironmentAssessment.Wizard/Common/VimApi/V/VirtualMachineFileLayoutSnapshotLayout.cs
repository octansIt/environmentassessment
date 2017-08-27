namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineFileLayoutSnapshotLayout : DynamicData
	{
		protected ManagedObjectReference _key;
		protected string[] _snapshotFile;
		protected VirtualMachineFileLayoutSnapshotLayout_LinkedView _linkedView;
		public ManagedObjectReference Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string[] SnapshotFile
		{
			get
			{
				return this._snapshotFile;
			}
			set
			{
				this._snapshotFile = value;
			}
		}
		public VirtualMachineFileLayoutSnapshotLayout_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
