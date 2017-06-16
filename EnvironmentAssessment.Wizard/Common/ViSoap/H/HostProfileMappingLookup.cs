namespace EnvironmentAssessment.Common.VISoap
{
    public class HostProfileMappingLookup : DynamicData
	{
		protected string _baseProfilePath;
		protected HostProfileMappingLookupMappingPair[] _apiMapping;
		protected HostProfileMappingLookupMappingPair[] _profileMapping;
		public string BaseProfilePath
		{
			get
			{
				return this._baseProfilePath;
			}
			set
			{
				this._baseProfilePath = value;
			}
		}
		public HostProfileMappingLookupMappingPair[] ApiMapping
		{
			get
			{
				return this._apiMapping;
			}
			set
			{
				this._apiMapping = value;
			}
		}
		public HostProfileMappingLookupMappingPair[] ProfileMapping
		{
			get
			{
				return this._profileMapping;
			}
			set
			{
				this._profileMapping = value;
			}
		}
	}
}
