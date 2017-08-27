namespace EnvironmentAssessment.Common.VimApi
{
	public class TaskFilterSpecByEntity : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected TaskFilterSpecRecursionOption _recursion;
		protected TaskFilterSpecByEntity_LinkedView _linkedView;
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
		public TaskFilterSpecRecursionOption Recursion
		{
			get
			{
				return this._recursion;
			}
			set
			{
				this._recursion = value;
			}
		}
		public TaskFilterSpecByEntity_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
