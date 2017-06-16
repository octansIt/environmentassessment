namespace EnvironmentAssessment.Common.VISoap
{
    public class ResourcePool_LinkedView : ManagedEntity_LinkedView
	{
		protected ComputeResource _owner;
		protected ResourcePool[] _resourcePool;
		protected VirtualMachine[] _vm;
		public ComputeResource Owner
		{
			get
			{
				return this._owner;
			}
		}
		public ResourcePool[] ResourcePool
		{
			get
			{
				return this._resourcePool;
			}
		}
		public VirtualMachine[] Vm
		{
			get
			{
				return this._vm;
			}
		}
	}
}
