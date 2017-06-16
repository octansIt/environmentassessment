namespace EnvironmentAssessment.Common.VISoap
{
    public class ImportOperationBulkFaultFaultOnImport : DynamicData
	{
		protected string _entityType;
		protected string _key;
		protected LocalizedMethodFault _fault;
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
