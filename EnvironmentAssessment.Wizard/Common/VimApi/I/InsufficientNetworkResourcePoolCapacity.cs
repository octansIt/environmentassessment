namespace EnvironmentAssessment.Common.VimApi
{
	public class InsufficientNetworkResourcePoolCapacity : InsufficientResourcesFault
	{
		protected string _dvsName;
		protected string _dvsUuid;
		protected string _resourcePoolKey;
		protected long _available;
		protected long _requested;
		protected string[] _device;
		public string DvsName
		{
			get
			{
				return this._dvsName;
			}
			set
			{
				this._dvsName = value;
			}
		}
		public string DvsUuid
		{
			get
			{
				return this._dvsUuid;
			}
			set
			{
				this._dvsUuid = value;
			}
		}
		public string ResourcePoolKey
		{
			get
			{
				return this._resourcePoolKey;
			}
			set
			{
				this._resourcePoolKey = value;
			}
		}
		public long Available
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
		public long Requested
		{
			get
			{
				return this._requested;
			}
			set
			{
				this._requested = value;
			}
		}
		public string[] Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
	}
}
