namespace EnvironmentAssessment.Common.VISoap
{
    public class RollbackFailure : DvsFault
	{
		protected string _entityName;
		protected string _entityType;
		public string EntityName
		{
			get
			{
				return this._entityName;
			}
			set
			{
				this._entityName = value;
			}
		}
		public string EntityType
		{
			get
			{
				return this._entityType;
			}
			set
			{
				this._entityType = value;
			}
		}
	}
}
