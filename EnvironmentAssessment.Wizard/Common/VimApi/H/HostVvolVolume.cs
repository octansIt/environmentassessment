namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVvolVolume : HostFileSystemVolume
	{
		protected string _scId;
		protected VVolHostPE[] _hostPE;
		protected VimVasaProviderInfo[] _vasaProviderInfo;
		protected VASAStorageArray[] _storageArray;
		public string ScId
		{
			get
			{
				return this._scId;
			}
			set
			{
				this._scId = value;
			}
		}
		public VVolHostPE[] HostPE
		{
			get
			{
				return this._hostPE;
			}
			set
			{
				this._hostPE = value;
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
	}
}
