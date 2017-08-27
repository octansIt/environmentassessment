namespace EnvironmentAssessment.Common.VimApi
{
	public class HbrDiskMigrationAction_LinkedView
	{
		protected Datastore _source;
		protected Datastore _destination;
		public Datastore Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}
		public Datastore Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
	}
}
