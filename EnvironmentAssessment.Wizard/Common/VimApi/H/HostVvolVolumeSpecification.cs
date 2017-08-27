namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVvolVolumeSpecification : DynamicData
	{
		protected long _maxSizeInMB;
		protected string _volumeName;
		protected VimVasaProviderInfo[] _vasaProviderInfo;
		protected VASAStorageArray[] _storageArray;
		protected string _uuid;
		public long MaxSizeInMB
		{
			get
			{
				return this._maxSizeInMB;
			}
			set
			{
				this._maxSizeInMB = value;
			}
		}
		public string VolumeName
		{
			get
			{
				return this._volumeName;
			}
			set
			{
				this._volumeName = value;
			}
		}
		public VimVasaProviderInfo[] VasaProviderInfo
		{
			get
			{
				return this._vasaProviderInfo;
			}
			set
			{
				this._vasaProviderInfo = value;
			}
		}
		public VASAStorageArray[] StorageArray
		{
			get
			{
				return this._storageArray;
			}
			set
			{
				this._storageArray = value;
			}
		}
		public string Uuid
		{
			get
			{
				return this._uuid;
			}
			set
			{
				this._uuid = value;
			}
		}
	}
}
