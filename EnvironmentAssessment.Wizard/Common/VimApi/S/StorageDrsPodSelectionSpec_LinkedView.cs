namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsPodSelectionSpec_LinkedView
	{
		protected StoragePod _storagePod;
		public StoragePod StoragePod
		{
			get
			{
				return this._storagePod;
			}
			set
			{
				this._storagePod = value;
			}
		}
	}
}
