namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppPropertyFault : VmConfigFault
	{
		protected string _id;
		protected string _category;
		protected string _label;
		protected string _type;
		protected string _value;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public string Category
		{
			get
			{
				return this._category;
			}
			set
			{
				this._category = value;
			}
		}
		public string Label
		{
			get
			{
				return this._label;
			}
			set
			{
				this._label = value;
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
