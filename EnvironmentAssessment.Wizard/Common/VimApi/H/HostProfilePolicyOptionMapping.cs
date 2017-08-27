namespace EnvironmentAssessment.Common.VimApi
{
    public class HostProfilePolicyOptionMapping : DynamicData
	{
		protected string _id;
		protected HostProfilePolicyOptionMappingPolicyOptionMappingData _data;
		protected HostProfileParameterMapping[] _parameterMapping;
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
		public HostProfilePolicyOptionMappingPolicyOptionMappingData Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public HostProfileParameterMapping[] ParameterMapping
		{
			get
			{
				return this._parameterMapping;
			}
			set
			{
				this._parameterMapping = value;
			}
		}
	}
}
