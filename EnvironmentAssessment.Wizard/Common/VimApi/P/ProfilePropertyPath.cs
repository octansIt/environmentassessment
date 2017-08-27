namespace EnvironmentAssessment.Common.VimApi
{
	public class ProfilePropertyPath : DynamicData
	{
		protected string _profilePath;
		protected string _policyId;
		protected string _parameterId;
		public string ProfilePath
		{
			get
			{
				return this._profilePath;
			}
			set
			{
				this._profilePath = value;
			}
		}
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
		public string ParameterId
		{
			get
			{
				return this._parameterId;
			}
			set
			{
				this._parameterId = value;
			}
		}
	}
}
