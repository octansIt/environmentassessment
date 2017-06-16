namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileMapping : DynamicData
	{
		protected string _apiId;
		protected string _profileTypeName;
		protected HostProfileMappingProfileMappingData _data;
		protected HostProfilePolicyMapping[] _policyMapping;
		public string ApiId
		{
			get
			{
				return this._apiId;
			}
			set
			{
				this._apiId = value;
			}
		}
		public string ProfileTypeName
		{
			get
			{
				return this._profileTypeName;
			}
			set
			{
				this._profileTypeName = value;
			}
		}
		public HostProfileMappingProfileMappingData Data
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
		public HostProfilePolicyMapping[] PolicyMapping
		{
			get
			{
				return this._policyMapping;
			}
			set
			{
				this._policyMapping = value;
			}
		}
	}
}
