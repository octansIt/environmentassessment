namespace EnvironmentAssessment.Common.VISoap
{
    public class EventArgDesc : DynamicData
	{
		protected string _name;
		protected string _type;
		protected bool? _array;
		protected bool? _eventObject;
		protected ElementDescription _description;
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
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		public bool? Array
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
		public bool? EventObject
		{
			get
			{
				return this._eventObject;
			}
			set
			{
				this._eventObject = value;
			}
		}
		public ElementDescription Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
	}
}
