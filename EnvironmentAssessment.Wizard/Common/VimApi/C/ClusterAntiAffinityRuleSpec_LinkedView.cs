namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterAntiAffinityRuleSpec_LinkedView
	{
		protected VirtualMachine[] _vm;
		public VirtualMachine[] Vm
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
	}
}
