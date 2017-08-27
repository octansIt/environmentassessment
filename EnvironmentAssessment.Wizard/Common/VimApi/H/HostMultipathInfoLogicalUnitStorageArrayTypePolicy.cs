namespace EnvironmentAssessment.Common.VimApi
{
	public class HostMultipathInfoLogicalUnitStorageArrayTypePolicy : DynamicData
	{
		protected string _policy;
		public string Policy
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
