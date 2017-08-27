namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostConfigInfoStorageInfo : DynamicData
	{
		protected bool? _autoClaimStorage;
		protected VsanHostDiskMapping[] _diskMapping;
		protected VsanHostDiskMapInfo[] _diskMapInfo;
		protected bool? _checksumEnabled;
		public bool? AutoClaimStorage
		{
			get
			{
				return this._autoClaimStorage;
			}
			set
			{
				this._autoClaimStorage = value;
			}
		}
		public VsanHostDiskMapping[] DiskMapping
		{
			get
			{
				return this._diskMapping;
			}
			set
			{
				this._diskMapping = value;
			}
		}
		public VsanHostDiskMapInfo[] DiskMapInfo
		{
			get
			{
				return this._diskMapInfo;
			}
			set
			{
				this._diskMapInfo = value;
			}
		}
		public bool? ChecksumEnabled
		{
			get
			{
				return this._checksumEnabled;
			}
			set
			{
				this._checksumEnabled = value;
			}
		}
	}
}
