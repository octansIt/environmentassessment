namespace EnvironmentAssessment.Common.VISoap
{
    public class ProfileMetadataProfileSortSpec : DynamicData
	{
		protected string _policyId;
		protected string _parameter;
		public string PolicyId
		{
			get
			{
				return this._policyId;
			}
			set
			{
				this._policyId = value;
			}
		}
		public string Parameter
		{
			get
			{
				return this._parameter;
			}
			set
			{
				this._parameter = value;
			}
		}
	}
}
