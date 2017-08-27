namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterDependencyRuleInfo : ClusterRuleInfo
	{
		protected string _vmGroup;
		protected string _dependsOnVmGroup;
		public string VmGroup
		{
			get
			{
				return this._vmGroup;
			}
			set
			{
				this._vmGroup = value;
			}
		}
		public string DependsOnVmGroup
		{
			get
			{
				return this._dependsOnVmGroup;
			}
			set
			{
				this._dependsOnVmGroup = value;
			}
		}
	}
}
