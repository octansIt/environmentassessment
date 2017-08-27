namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineDatastoreInfo : VirtualMachineTargetInfo
	{
		protected DatastoreSummary _datastore;
		protected DatastoreCapability _capability;
		protected long _maxFileSize;
		protected long? _maxVirtualDiskCapacity;
		protected long? _maxPhysicalRDMFileSize;
		protected long? _maxVirtualRDMFileSize;
		protected string _mode;
		protected string _vStorageSupport;
		public DatastoreSummary Datastore
		{
			get
			{
				return this._datastore;
			}
			set
			{
				this._datastore = value;
			}
		}
		public DatastoreCapability Capability
		{
			get
			{
				return this._capability;
			}
			set
			{
				this._capability = value;
			}
		}
		public long MaxFileSize
		{
			get
			{
				return this._maxFileSize;
			}
			set
			{
				this._maxFileSize = value;
			}
		}
		public long? MaxVirtualDiskCapacity
		{
			get
			{
				return this._maxVirtualDiskCapacity;
			}
			set
			{
				this._maxVirtualDiskCapacity = value;
			}
		}
		public long? MaxPhysicalRDMFileSize
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
		public long? MaxVirtualRDMFileSize
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
		public string Mode
		{
			get
			{
				return this._mode;
			}
			set
			{
				this._mode = value;
			}
		}
		public string VStorageSupport
		{
			get
			{
				return this._vStorageSupport;
			}
			set
			{
				this._vStorageSupport = value;
			}
		}
	}
}
