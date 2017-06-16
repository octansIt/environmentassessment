namespace EnvironmentAssessment.Common.VISoap
{
    public class HostVFlashManagerVFlashResourceRunTimeInfo : DynamicData
	{
		protected long _usage;
		protected long _capacity;
		protected bool _accessible;
		protected long _capacityForVmCache;
		protected long _freeForVmCache;
		public long Usage
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
		public long Capacity
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
		public bool Accessible
		{
			get
			{
				return this._accessible;
			}
			set
			{
				this._accessible = value;
			}
		}
		public long CapacityForVmCache
		{
			get
			{
				return this._capacityForVmCache;
			}
			set
			{
				this._capacityForVmCache = value;
			}
		}
		public long FreeForVmCache
		{
			get
			{
				return this._freeForVmCache;
			}
			set
			{
				this._freeForVmCache = value;
			}
		}
	}
}
