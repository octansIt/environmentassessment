namespace EnvironmentAssessment.Common.VISoap
{
    public class CustomFieldValueChangedEvent : CustomFieldEvent
	{
		protected ManagedEntityEventArgument _entity;
		protected int _fieldKey;
		protected string _name;
		protected string _value;
		public ManagedEntityEventArgument Entity
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
		public int FieldKey
		{
			get
			{
				return this._fieldKey;
			}
			set
			{
				this._fieldKey = value;
			}
		}
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
		public string Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
	}
}
