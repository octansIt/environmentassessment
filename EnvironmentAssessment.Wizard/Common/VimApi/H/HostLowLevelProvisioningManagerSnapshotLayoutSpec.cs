namespace EnvironmentAssessment.Common.VimApi
{
	public class HostLowLevelProvisioningManagerSnapshotLayoutSpec : DynamicData
	{
		protected int _id;
		protected string _srcFilename;
		protected string _dstFilename;
		protected HostLowLevelProvisioningManagerDiskLayoutSpec[] _disk;
		public int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string SrcFilename
		{
			get
			{
				return this._srcFilename;
			}
			set
			{
				this._srcFilename = value;
			}
		}
		public string DstFilename
		{
			get
			{
				return this._dstFilename;
			}
			set
			{
				this._dstFilename = value;
			}
		}
		public HostLowLevelProvisioningManagerDiskLayoutSpec[] Disk
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
	}
}
