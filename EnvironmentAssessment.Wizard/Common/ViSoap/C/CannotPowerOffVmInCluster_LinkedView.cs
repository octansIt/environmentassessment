namespace EnvironmentAssessment.Common.VISoap
{
    public class CannotPowerOffVmInCluster_LinkedView
	{
		protected VirtualMachine _vm;
		public VirtualMachine Vm
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
