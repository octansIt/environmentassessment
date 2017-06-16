namespace EnvironmentAssessment.Common.VISoap
{
    public class BackupBlobWriteFailure : DvsFault
	{
		protected string _entityName;
		protected string _entityType;
		protected LocalizedMethodFault _fault;
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
		public LocalizedMethodFault Fault
		{
			get
			{
				return this._fault;
			}
			set
			{
				this._fault = value;
			}
		}
	}
}
