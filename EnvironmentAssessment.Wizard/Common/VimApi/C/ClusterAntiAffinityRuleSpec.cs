namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterAntiAffinityRuleSpec : ClusterRuleInfo
	{
		protected ManagedObjectReference[] _vm;
		protected ClusterAntiAffinityRuleSpec_LinkedView _linkedView;
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
		public ClusterAntiAffinityRuleSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
