namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageResourceManagerStorageProfileStatistics : DynamicData
	{
		protected string _profileId;
		protected long _totalSpaceMB;
		protected long _usedSpaceMB;
		public string ProfileId
		{
			get
			{
				return this._profileId;
			}
			set
			{
				this._profileId = value;
			}
		}
		public long TotalSpaceMB
		{
			get
			{
				return this._totalSpaceMB;
			}
			set
			{
				this._totalSpaceMB = value;
			}
		}
		public long UsedSpaceMB
		{
			get
			{
				return this._usedSpaceMB;
			}
			set
			{
				this._usedSpaceMB = value;
			}
		}
	}
}
