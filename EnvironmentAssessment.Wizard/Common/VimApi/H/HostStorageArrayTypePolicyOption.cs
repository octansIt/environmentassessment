namespace EnvironmentAssessment.Common.VimApi
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
