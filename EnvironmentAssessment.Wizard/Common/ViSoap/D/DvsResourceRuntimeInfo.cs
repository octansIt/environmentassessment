namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsResourceRuntimeInfo : DynamicData
	{
		protected int? _capacity;
		protected int? _usage;
		protected int? _available;
		protected DvsVnicAllocatedResource[] _allocatedResource;
		protected DvsVmVnicNetworkResourcePoolRuntimeInfo[] _vmVnicNetworkResourcePoolRuntime;
		public int? Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
		public int? Usage
		{
			get
			{
				return this._usage;
			}
			set
			{
				this._usage = value;
			}
		}
		public int? Available
		{
			get
			{
				return this._available;
			}
			set
			{
				this._available = value;
			}
		}
		public DvsVnicAllocatedResource[] AllocatedResource
		{
			get
			{
				return this._allocatedResource;
			}
			set
			{
				this._allocatedResource = value;
			}
		}
		public DvsVmVnicNetworkResourcePoolRuntimeInfo[] VmVnicNetworkResourcePoolRuntime
		{
			get
			{
				return this._vmVnicNetworkResourcePoolRuntime;
			}
			set
			{
				this._vmVnicNetworkResourcePoolRuntime = value;
			}
		}
	}
}
