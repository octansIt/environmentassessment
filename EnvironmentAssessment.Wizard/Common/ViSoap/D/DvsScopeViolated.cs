namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsScopeViolated : DvsFault
	{
		protected ManagedObjectReference[] _scope;
		protected ManagedObjectReference _entity;
		protected DvsScopeViolated_LinkedView _linkedView;
		public ManagedObjectReference[] Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
			}
		}
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
		public DvsScopeViolated_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
