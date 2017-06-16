namespace EnvironmentAssessment.Common.VISoap
{
    public class EntityPrivilege : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected PrivilegeAvailability[] _privAvailability;
		protected EntityPrivilege_LinkedView _linkedView;
		public ManagedObjectReference Entity
		{
			get
			{
				return this._entity;
			}
			set
			{
				this._entity = value;
			}
		}
		public PrivilegeAvailability[] PrivAvailability
		{
			get
			{
				return this._privAvailability;
			}
			set
			{
				this._privAvailability = value;
			}
		}
		public EntityPrivilege_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
