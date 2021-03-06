namespace EnvironmentAssessment.Common.VimApi
{
	public class DVPortSetting : DynamicData
	{
		protected BoolPolicy _blocked;
		protected BoolPolicy _vmDirectPathGen2Allowed;
		protected DVSTrafficShapingPolicy _inShapingPolicy;
		protected DVSTrafficShapingPolicy _outShapingPolicy;
		protected DVSVendorSpecificConfig _vendorSpecificConfig;
		protected StringPolicy _networkResourcePoolKey;
		protected DvsFilterPolicy _filterPolicy;
		public BoolPolicy Blocked
		{
			get
			{
				return this._blocked;
			}
			set
			{
				this._blocked = value;
			}
		}
		public BoolPolicy VmDirectPathGen2Allowed
		{
			get
			{
				return this._vmDirectPathGen2Allowed;
			}
			set
			{
				this._vmDirectPathGen2Allowed = value;
			}
		}
		public DVSTrafficShapingPolicy InShapingPolicy
		{
			get
			{
				return this._inShapingPolicy;
			}
			set
			{
				this._inShapingPolicy = value;
			}
		}
		public DVSTrafficShapingPolicy OutShapingPolicy
		{
			get
			{
				return this._outShapingPolicy;
			}
			set
			{
				this._outShapingPolicy = value;
			}
		}
		public DVSVendorSpecificConfig VendorSpecificConfig
		{
			get
			{
				return this._vendorSpecificConfig;
			}
			set
			{
				this._vendorSpecificConfig = value;
			}
		}
		public StringPolicy NetworkResourcePoolKey
		{
			get
			{
				return this._networkResourcePoolKey;
			}
			set
			{
				this._networkResourcePoolKey = value;
			}
		}
		public DvsFilterPolicy FilterPolicy
		{
			get
			{
				return this._filterPolicy;
			}
			set
			{
				this._filterPolicy = value;
			}
		}
	}
}
