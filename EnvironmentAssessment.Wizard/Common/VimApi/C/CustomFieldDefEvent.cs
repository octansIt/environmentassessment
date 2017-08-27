namespace EnvironmentAssessment.Common.VimApi
{
	public class CustomFieldDefEvent : CustomFieldEvent
	{
		protected int _fieldKey;
		protected string _name;
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
	}
}
