namespace EnvironmentAssessment.Common.VISoap
{
    public class InvalidName : VimFault
	{
		protected string _name;
		protected ManagedObjectReference _entity;
		protected InvalidName_LinkedView _linkedView;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
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
		public InvalidName_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
