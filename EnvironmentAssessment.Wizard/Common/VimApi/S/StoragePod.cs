namespace EnvironmentAssessment.Common.VimApi
{
	public class StoragePod : Folder
	{
		protected StoragePodSummary _summary;
		protected PodStorageDrsEntry _podStorageDrsEntry;
		public StoragePodSummary Summary
		{
			get
			{
				return this._summary;
			}
		}
		public PodStorageDrsEntry PodStorageDrsEntry
		{
			get
			{
				return this._podStorageDrsEntry;
			}
		}
		public new StoragePod_LinkedView LinkedView
		{
			get
			{
				return (StoragePod_LinkedView)this._linkedView;
			}
		}
		public StoragePod(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
