namespace EnvironmentAssessment.Common.VimApi
{
	public class ManagedEntityEventArgument : EntityEventArgument
	{
		protected ManagedObjectReference _entity;
		protected ManagedEntityEventArgument_LinkedView _linkedView;
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
		public ManagedEntityEventArgument_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
