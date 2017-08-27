namespace EnvironmentAssessment.Common.VimApi
{
	public class ManagedEntityEventArgument_LinkedView
	{
		protected ManagedEntity _entity;
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
