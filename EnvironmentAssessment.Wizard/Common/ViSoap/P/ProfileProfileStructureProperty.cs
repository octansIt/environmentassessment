namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileProfileStructureProperty : DynamicData
	{
		protected string _propertyName;
		protected bool _array;
		protected ProfileProfileStructure _element;
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
			set
			{
				this._propertyName = value;
			}
		}
		public bool Array
		{
			get
			{
				return this._array;
			}
			set
			{
				this._array = value;
			}
		}
		public ProfileProfileStructure Element
		{
			get
			{
				return this._element;
			}
			set
			{
				this._element = value;
			}
		}
	}
}
