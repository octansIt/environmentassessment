namespace EnvironmentAssessment.Common.VISoap
{
    public class VmfsDatastoreInfo : DatastoreInfo
	{
		protected long _maxPhysicalRDMFileSize;
		protected long _maxVirtualRDMFileSize;
		protected HostVmfsVolume _vmfs;
		protected VmfsDatastoreInfoScsiLunInfo[] _lun;
		public long MaxPhysicalRDMFileSize
		{
			get
			{
				return this._maxPhysicalRDMFileSize;
			}
			set
			{
				this._maxPhysicalRDMFileSize = value;
			}
		}
		public long MaxVirtualRDMFileSize
		{
			get
			{
				return this._maxVirtualRDMFileSize;
			}
			set
			{
				this._maxVirtualRDMFileSize = value;
			}
		}
		public HostVmfsVolume Vmfs
		{
			get
			{
				return this._vmfs;
			}
			set
			{
				this._vmfs = value;
			}
		}
		public VmfsDatastoreInfoScsiLunInfo[] Lun
		{
			get
			{
				return this._lun;
			}
			set
			{
				this._lun = value;
			}
		}
	}
}
