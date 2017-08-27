namespace EnvironmentAssessment.Common.VimApi
{
	public class InventoryDescription : DynamicData
	{
		protected int _numHosts;
		protected int _numVirtualMachines;
		protected int? _numResourcePools;
		protected int? _numClusters;
		protected int? _numCpuDev;
		protected int? _numNetDev;
		protected int? _numDiskDev;
		protected int? _numvCpuDev;
		protected int? _numvNetDev;
		protected int? _numvDiskDev;
		public int NumHosts
		{
			get
			{
				return this._numHosts;
			}
			set
			{
				this._numHosts = value;
			}
		}
		public int NumVirtualMachines
		{
			get
			{
				return this._numVirtualMachines;
			}
			set
			{
				this._numVirtualMachines = value;
			}
		}
		public int? NumResourcePools
		{
			get
			{
				return this._numResourcePools;
			}
			set
			{
				this._numResourcePools = value;
			}
		}
		public int? NumClusters
		{
			get
			{
				return this._numClusters;
			}
			set
			{
				this._numClusters = value;
			}
		}
		public int? NumCpuDev
		{
			get
			{
				return this._numCpuDev;
			}
			set
			{
				this._numCpuDev = value;
			}
		}
		public int? NumNetDev
		{
			get
			{
				return this._numNetDev;
			}
			set
			{
				this._numNetDev = value;
			}
		}
		public int? NumDiskDev
		{
			get
			{
				return this._numDiskDev;
			}
			set
			{
				this._numDiskDev = value;
			}
		}
		public int? NumvCpuDev
		{
			get
			{
				return this._numvCpuDev;
			}
			set
			{
				this._numvCpuDev = value;
			}
		}
		public int? NumvNetDev
		{
			get
			{
				return this._numvNetDev;
			}
			set
			{
				this._numvNetDev = value;
			}
		}
		public int? NumvDiskDev
		{
			get
			{
				return this._numvDiskDev;
			}
			set
			{
				this._numvDiskDev = value;
			}
		}
	}
}
