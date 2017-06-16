namespace EnvironmentAssessment.Common.VISoap
{
    public class ClusterVmGroup_LinkedView
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
