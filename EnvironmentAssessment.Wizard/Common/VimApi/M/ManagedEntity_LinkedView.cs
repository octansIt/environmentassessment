namespace EnvironmentAssessment.Common.VimApi
{
	public class ManagedEntity_LinkedView
	{
		protected ManagedEntity _parent;
		protected Task[] _recentTask;
		public ManagedEntity Parent
		{
			get
			{
				return this._parent;
			}
		}
		public Task[] RecentTask
		{
			get
			{
				return this._recentTask;
			}
		}
	}
}
