namespace EnvironmentAssessment.Common.VimApi
{
	public class PlacementAction : ClusterAction
	{
		protected ManagedObjectReference _vm;
		protected ManagedObjectReference _targetHost;
		protected VirtualMachineRelocateSpec _relocateSpec;
		protected PlacementAction_LinkedView _linkedView;
		public ManagedObjectReference Vm
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
		public ManagedObjectReference TargetHost
		{
			get
			{
				return this._targetHost;
			}
			set
			{
				this._targetHost = value;
			}
		}
		public VirtualMachineRelocateSpec RelocateSpec
		{
			get
			{
				return this._relocateSpec;
			}
			set
			{
				this._relocateSpec = value;
			}
		}
		public PlacementAction_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
