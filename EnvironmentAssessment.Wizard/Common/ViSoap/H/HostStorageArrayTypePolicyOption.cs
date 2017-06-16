namespace EnvironmentAssessment.Common.VISoap
{
    public class HostStorageArrayTypePolicyOption : DynamicData
	{
		protected ElementDescription _policy;
		public ElementDescription Policy
		{
			get
			{
				return this._policy;
			}
			set
			{
				this._policy = value;
			}
		}
	}
}
