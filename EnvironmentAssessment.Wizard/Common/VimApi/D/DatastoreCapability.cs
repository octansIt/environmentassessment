namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreCapability : DynamicData
	{
		protected bool _directoryHierarchySupported;
		protected bool _rawDiskMappingsSupported;
		protected bool _perFileThinProvisioningSupported;
		protected bool _storageIORMSupported;
		protected bool _nativeSnapshotSupported;
		protected bool? _topLevelDirectoryCreateSupported;
		protected bool? _seSparseSupported;
		protected bool? _vmfsSparseSupported;
		protected bool? _vsanSparseSupported;
		protected bool? _upitSupported;
		public bool DirectoryHierarchySupported
		{
			get
			{
				return this._directoryHierarchySupported;
			}
			set
			{
				this._directoryHierarchySupported = value;
			}
		}
		public bool RawDiskMappingsSupported
		{
			get
			{
				return this._rawDiskMappingsSupported;
			}
			set
			{
				this._rawDiskMappingsSupported = value;
			}
		}
		public bool PerFileThinProvisioningSupported
		{
			get
			{
				return this._perFileThinProvisioningSupported;
			}
			set
			{
				this._perFileThinProvisioningSupported = value;
			}
		}
		public bool StorageIORMSupported
		{
			get
			{
				return this._storageIORMSupported;
			}
			set
			{
				this._storageIORMSupported = value;
			}
		}
		public bool NativeSnapshotSupported
		{
			get
			{
				return this._nativeSnapshotSupported;
			}
			set
			{
				this._nativeSnapshotSupported = value;
			}
		}
		public bool? TopLevelDirectoryCreateSupported
		{
			get
			{
				return this._topLevelDirectoryCreateSupported;
			}
			set
			{
				this._topLevelDirectoryCreateSupported = value;
			}
		}
		public bool? SeSparseSupported
		{
			get
			{
				return this._seSparseSupported;
			}
			set
			{
				this._seSparseSupported = value;
			}
		}
		public bool? VmfsSparseSupported
		{
			get
			{
				return this._vmfsSparseSupported;
			}
			set
			{
				this._vmfsSparseSupported = value;
			}
		}
		public bool? VsanSparseSupported
		{
			get
			{
				return this._vsanSparseSupported;
			}
			set
			{
				this._vsanSparseSupported = value;
			}
		}
		public bool? UpitSupported
		{
			get
			{
				return this._upitSupported;
			}
			set
			{
				this._upitSupported = value;
			}
		}
	}
}
