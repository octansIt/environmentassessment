namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterAffinityRuleSpec : ClusterRuleInfo
	{
		protected ManagedObjectReference[] _vm;
		protected ClusterAffinityRuleSpec_LinkedView _linkedView;
		public ManagedObjectReference[] Vm
		{
			get
			{
				return this._vm;
			}
			set
			{
				this._vm = value;
			}
		}
		public ClusterAffinityRuleSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
