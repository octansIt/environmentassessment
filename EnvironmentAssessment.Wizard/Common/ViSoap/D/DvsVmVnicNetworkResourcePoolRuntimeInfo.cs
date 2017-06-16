namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsVmVnicNetworkResourcePoolRuntimeInfo : DynamicData
	{
		protected string _key;
		protected string _name;
		protected int? _capacity;
		protected int? _usage;
		protected int? _available;
		protected string _status;
		protected DvsVnicAllocatedResource[] _allocatedResource;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
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
		public string Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
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
	}
}
