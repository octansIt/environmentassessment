namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileMappingData : DynamicData
	{
		protected string _basePath;
		protected string _attributePath;
		protected HostProfileAttributeCondition _condition;
		protected HostProfileMappingLookup _lookup;
		public string BasePath
		{
			get
			{
				return this._basePath;
			}
			set
			{
				this._basePath = value;
			}
		}
		public string AttributePath
		{
			get
			{
				return this._attributePath;
			}
			set
			{
				this._attributePath = value;
			}
		}
		public HostProfileAttributeCondition Condition
		{
			get
			{
				return this._condition;
			}
			set
			{
				this._condition = value;
			}
		}
		public HostProfileMappingLookup Lookup
		{
			get
			{
				return this._lookup;
			}
			set
			{
				this._lookup = value;
			}
		}
	}
}
