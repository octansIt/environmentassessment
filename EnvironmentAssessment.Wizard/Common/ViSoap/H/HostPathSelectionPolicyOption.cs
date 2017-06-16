namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPathSelectionPolicyOption : DynamicData
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
