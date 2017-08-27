namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageMigrationAction : ClusterAction
	{
		protected ManagedObjectReference _vm;
		protected VirtualMachineRelocateSpec _relocateSpec;
		protected ManagedObjectReference _source;
		protected ManagedObjectReference _destination;
		protected long _sizeTransferred;
		protected float? _spaceUtilSrcBefore;
		protected float? _spaceUtilDstBefore;
		protected float? _spaceUtilSrcAfter;
		protected float? _spaceUtilDstAfter;
		protected float? _ioLatencySrcBefore;
		protected float? _ioLatencyDstBefore;
		protected StorageMigrationAction_LinkedView _linkedView;
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
		public ManagedObjectReference Source
		{
			get
			{
				return this._source;
			}
			set
			{
				this._source = value;
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
		public long SizeTransferred
		{
			get
			{
				return this._sizeTransferred;
			}
			set
			{
				this._sizeTransferred = value;
			}
		}
		public float? SpaceUtilSrcBefore
		{
			get
			{
				return this._spaceUtilSrcBefore;
			}
			set
			{
				this._spaceUtilSrcBefore = value;
			}
		}
		public float? SpaceUtilDstBefore
		{
			get
			{
				return this._spaceUtilDstBefore;
			}
			set
			{
				this._spaceUtilDstBefore = value;
			}
		}
		public float? SpaceUtilSrcAfter
		{
			get
			{
				return this._spaceUtilSrcAfter;
			}
			set
			{
				this._spaceUtilSrcAfter = value;
			}
		}
		public float? SpaceUtilDstAfter
		{
			get
			{
				return this._spaceUtilDstAfter;
			}
			set
			{
				this._spaceUtilDstAfter = value;
			}
		}
		public float? IoLatencySrcBefore
		{
			get
			{
				return this._ioLatencySrcBefore;
			}
			set
			{
				this._ioLatencySrcBefore = value;
			}
		}
		public float? IoLatencyDstBefore
		{
			get
			{
				return this._ioLatencyDstBefore;
			}
			set
			{
				this._ioLatencyDstBefore = value;
			}
		}
		public StorageMigrationAction_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
