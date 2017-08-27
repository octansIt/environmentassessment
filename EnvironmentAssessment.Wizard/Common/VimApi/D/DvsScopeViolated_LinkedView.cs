namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsScopeViolated_LinkedView
	{
		protected ManagedEntity[] _scope;
		protected ManagedEntity _entity;
		public ManagedEntity[] Scope
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
		public ManagedEntity Entity
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
	}
}
