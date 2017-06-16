namespace EnvironmentAssessment.Common.VISoap
{
    public class IscsiMigrationDependency : DynamicData
	{
		protected bool _migrationAllowed;
		protected IscsiStatus _disallowReason;
		protected IscsiDependencyEntity[] _dependency;
		public bool MigrationAllowed
		{
			get
			{
				return this._migrationAllowed;
			}
			set
			{
				this._migrationAllowed = value;
			}
		}
		public IscsiStatus DisallowReason
		{
			get
			{
				return this._disallowReason;
			}
			set
			{
				this._disallowReason = value;
			}
		}
		public IscsiDependencyEntity[] Dependency
		{
			get
			{
				return this._dependency;
			}
			set
			{
				this._dependency = value;
			}
		}
	}
}
