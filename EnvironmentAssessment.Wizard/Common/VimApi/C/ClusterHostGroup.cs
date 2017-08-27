namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterHostGroup : ClusterGroupInfo
	{
		protected ManagedObjectReference[] _host;
		protected ClusterHostGroup_LinkedView _linkedView;
		public ManagedObjectReference[] Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public ClusterHostGroup_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
