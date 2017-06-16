namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileParameterMetadata : DynamicData
	{
		protected ExtendedElementDescription _id;
		protected string _type;
		protected bool _optional;
		protected object _defaultValue;
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
	}
}
