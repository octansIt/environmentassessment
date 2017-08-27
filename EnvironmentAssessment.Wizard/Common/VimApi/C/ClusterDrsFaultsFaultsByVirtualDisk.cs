namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDrsFaultsFaultsByVirtualDisk : ClusterDrsFaultsFaultsByVm
	{
		protected VirtualDiskId _disk;
		public VirtualDiskId Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
		public new ClusterDrsFaultsFaultsByVirtualDisk_LinkedView LinkedView
		{
			get
			{
				return (ClusterDrsFaultsFaultsByVirtualDisk_LinkedView)this._linkedView;
			}
		}
	}
}
