namespace EnvironmentAssessment.Common.VimApi
{
	public class StoragePlacementAction : ClusterAction
	{
		protected ManagedObjectReference _vm;
		protected VirtualMachineRelocateSpec _relocateSpec;
		protected ManagedObjectReference _destination;
		protected float? _spaceUtilBefore;
		protected float? _spaceDemandBefore;
		protected float? _spaceUtilAfter;
		protected float? _spaceDemandAfter;
		protected float? _ioLatencyBefore;
		protected StoragePlacementAction_LinkedView _linkedView;
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
		public ManagedObjectReference Destination
		{
			get
			{
				return this._destination;
			}
			set
			{
				this._destination = value;
			}
		}
		public float? SpaceUtilBefore
		{
			get
			{
				return this._spaceUtilBefore;
			}
			set
			{
				this._spaceUtilBefore = value;
			}
		}
		public float? SpaceDemandBefore
		{
			get
			{
				return this._spaceDemandBefore;
			}
			set
			{
				this._spaceDemandBefore = value;
			}
		}
		public float? SpaceUtilAfter
		{
			get
			{
				return this._spaceUtilAfter;
			}
			set
			{
				this._spaceUtilAfter = value;
			}
		}
		public float? SpaceDemandAfter
		{
			get
			{
				return this._spaceDemandAfter;
			}
			set
			{
				this._spaceDemandAfter = value;
			}
		}
		public float? IoLatencyBefore
		{
			get
			{
				return this._ioLatencyBefore;
			}
			set
			{
				this._ioLatencyBefore = value;
			}
		}
		public StoragePlacementAction_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
