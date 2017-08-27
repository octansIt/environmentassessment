namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppPropertyInfo : DynamicData
	{
		protected int _key;
		protected string _classId;
		protected string _instanceId;
		protected string _id;
		protected string _category;
		protected string _label;
		protected string _type;
		protected string _typeReference;
		protected bool? _userConfigurable;
		protected string _defaultValue;
		protected string _value;
		protected string _description;
		public int Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string ClassId
		{
			get
			{
				return this._classId;
			}
			set
			{
				this._classId = value;
			}
		}
		public string InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				this._instanceId = value;
			}
		}
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
		public string TypeReference
		{
			get
			{
				return this._typeReference;
			}
			set
			{
				this._typeReference = value;
			}
		}
		public bool? UserConfigurable
		{
			get
			{
				return this._userConfigurable;
			}
			set
			{
				this._userConfigurable = value;
			}
		}
		public string DefaultValue
		{
			get
			{
				return this._defaultValue;
			}
			set
			{
				this._defaultValue = value;
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
		public string Description
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
