namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterDrsRecommendation : DynamicData
	{
		protected string _key;
		protected int _rating;
		protected string _reason;
		protected string _reasonText;
		protected ClusterDrsMigration[] _migrationList;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public int Rating
		{
			get
			{
				return this._rating;
			}
			set
			{
				this._rating = value;
			}
		}
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				this._reason = value;
			}
		}
		public string ReasonText
		{
			get
			{
				return this._reasonText;
			}
			set
			{
				this._reasonText = value;
			}
		}
		public ClusterDrsMigration[] MigrationList
		{
			get
			{
				return this._migrationList;
			}
			set
			{
				this._migrationList = value;
			}
		}
	}
}
