namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterProfileManager : ProfileManager
	{
		public new ClusterProfileManager_LinkedView LinkedView
		{
			get
			{
				return (ClusterProfileManager_LinkedView)this._linkedView;
			}
		}
		public ClusterProfileManager(VimClient client, ManagedObjectReference moRef) : base(client, moRef)
		{
		}
	}
}
