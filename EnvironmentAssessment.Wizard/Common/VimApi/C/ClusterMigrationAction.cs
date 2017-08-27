namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterMigrationAction : ClusterAction
	{
		protected ClusterDrsMigration _drsMigration;
		public ClusterDrsMigration DrsMigration
		{
			get
			{
				return this._drsMigration;
			}
			set
			{
				this._drsMigration = value;
			}
		}
	}
}
