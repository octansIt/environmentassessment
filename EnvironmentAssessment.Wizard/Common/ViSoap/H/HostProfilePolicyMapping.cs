namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfilePolicyMapping : DynamicData
	{
		protected string _id;
		protected HostProfilePolicyMappingPolicyMappingData _data;
		protected HostProfilePolicyOptionMapping[] _policyOptionMapping;
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
		public HostProfilePolicyMappingPolicyMappingData Data
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
		public HostProfilePolicyOptionMapping[] PolicyOptionMapping
		{
			get
			{
				return this._policyOptionMapping;
			}
			set
			{
				this._policyOptionMapping = value;
			}
		}
	}
}
