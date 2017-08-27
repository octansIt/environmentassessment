namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMultipathInfoLogicalUnit : DynamicData
	{
		protected string _key;
		protected string _id;
		protected string _lun;
		protected HostMultipathInfoPath[] _path;
		protected HostMultipathInfoLogicalUnitPolicy _policy;
		protected HostMultipathInfoLogicalUnitStorageArrayTypePolicy _storageArrayTypePolicy;
		public string Key
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
		public string Id
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
		public string Lun
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
		public HostMultipathInfoPath[] Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public HostMultipathInfoLogicalUnitPolicy Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
		public HostMultipathInfoLogicalUnitStorageArrayTypePolicy StorageArrayTypePolicy
		{
			get
			{
				return this._storageArrayTypePolicy;
			}
			set
			{
				this._storageArrayTypePolicy = value;
			}
		}
	}
}
