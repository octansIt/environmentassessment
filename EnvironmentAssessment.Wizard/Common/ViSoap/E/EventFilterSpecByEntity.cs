namespace EnvironmentAssessment.Common.VISoap
{
    public class EventFilterSpecByEntity : DynamicData
	{
		protected ManagedObjectReference _entity;
		protected EventFilterSpecRecursionOption _recursion;
		protected EventFilterSpecByEntity_LinkedView _linkedView;
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
		public EventFilterSpecRecursionOption Recursion
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
		public EventFilterSpecByEntity_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
