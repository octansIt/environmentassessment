namespace EnvironmentAssessment.Common.VISoap
{
    public class HostLowLevelProvisioningManagerVmMigrationStatus : DynamicData
	{
		protected long _migrationId;
		protected string _type;
		protected bool _source;
		protected bool _consideredSuccessful;
		public long MigrationId
		{
			get
			{
				return this._migrationId;
			}
			set
			{
				this._migrationId = value;
			}
		}
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public bool Source
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
		public bool ConsideredSuccessful
		{
			get
			{
				return this._consideredSuccessful;
			}
			set
			{
				this._consideredSuccessful = value;
			}
		}
	}
}
