namespace EnvironmentAssessment.Common.VISoap
{
    public class DuplicateName : VimFault
	{
		protected string _name;
		protected ManagedObjectReference _object;
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
		public ManagedObjectReference Object
		{
			get
			{
				return this._object;
			}
			set
			{
				this._object = value;
			}
		}
	}
}
