namespace EnvironmentAssessment.Common.VISoap
{
    public class VsanHostConfigInfoStorageInfo : DynamicData
	{
		protected bool? _autoClaimStorage;
		protected VsanHostDiskMapping[] _diskMapping;
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
	}
}
