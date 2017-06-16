namespace EnvironmentAssessment.Common.VISoap
{
    public class DVPortSetting : DynamicData
	{
		protected BoolPolicy _blocked;
		protected BoolPolicy _vmDirectPathGen2Allowed;
		protected DVSTrafficShapingPolicy _inShapingPolicy;
		protected DVSTrafficShapingPolicy _outShapingPolicy;
		protected DVSoverlayParameterPolicy _overlayParameter;
		protected DVSVendorSpecificConfig _vendorSpecificConfig;
		protected StringPolicy _networkResourcePoolKey;
		protected DVSSwitchSecurityConfig _switchSecurityConfig;
		protected DvsFilterPolicy _filterPolicy;
		protected DvsStatefulFirewallPolicy _statefulFirewallPolicy;
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
		public DVSoverlayParameterPolicy OverlayParameter
		{
			get
			{
				return this._overlayParameter;
			}
			set
			{
				this._overlayParameter = value;
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
		public DVSSwitchSecurityConfig SwitchSecurityConfig
		{
			get
			{
				return this._switchSecurityConfig;
			}
			set
			{
				this._switchSecurityConfig = value;
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
		public DvsStatefulFirewallPolicy StatefulFirewallPolicy
		{
			get
			{
				return this._statefulFirewallPolicy;
			}
			set
			{
				this._statefulFirewallPolicy = value;
			}
		}
	}
}
