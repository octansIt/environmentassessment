namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfileParameterMetadata : DynamicData
	{
		protected ExtendedElementDescription _id;
		protected string _type;
		protected bool _optional;
		protected object _defaultValue;
		protected bool? _hidden;
		protected bool? _securitySensitive;
		protected bool? _readOnly;
		public ExtendedElementDescription Id
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
		public bool Optional
		{
			get
			{
				return this._optional;
			}
			set
			{
				this._optional = value;
			}
		}
		public object DefaultValue
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
		public bool? Hidden
		{
			get
			{
				return this._hidden;
			}
			set
			{
				this._hidden = value;
			}
		}
		public bool? SecuritySensitive
		{
			get
			{
				return this._securitySensitive;
			}
			set
			{
				this._securitySensitive = value;
			}
		}
		public bool? ReadOnly
		{
			get
			{
				return this._readOnly;
			}
			set
			{
				this._readOnly = value;
			}
		}
	}
}
