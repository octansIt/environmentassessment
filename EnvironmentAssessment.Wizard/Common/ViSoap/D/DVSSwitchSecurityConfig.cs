namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSSwitchSecurityConfig : InheritablePolicy
	{
		protected BoolPolicy _bpduFilterEnabled;
		protected BoolPolicy _dhcpServerBlockEnabled;
		protected DVSIPDiscoveryConfig _ipDiscoveryConfig;
		protected DVSDynamicArpInspectionConfig _dynamicArpInspectionConfig;
		protected BoolPolicy _ipSrcGuardEnabled;
		public BoolPolicy BpduFilterEnabled
		{
			get
			{
				return this._bpduFilterEnabled;
			}
			set
			{
				this._bpduFilterEnabled = value;
			}
		}
		public BoolPolicy DhcpServerBlockEnabled
		{
			get
			{
				return this._dhcpServerBlockEnabled;
			}
			set
			{
				this._dhcpServerBlockEnabled = value;
			}
		}
		public DVSIPDiscoveryConfig IpDiscoveryConfig
		{
			get
			{
				return this._ipDiscoveryConfig;
			}
			set
			{
				this._ipDiscoveryConfig = value;
			}
		}
		public DVSDynamicArpInspectionConfig DynamicArpInspectionConfig
		{
			get
			{
				return this._dynamicArpInspectionConfig;
			}
			set
			{
				this._dynamicArpInspectionConfig = value;
			}
		}
		public BoolPolicy IpSrcGuardEnabled
		{
			get
			{
				return this._ipSrcGuardEnabled;
			}
			set
			{
				this._ipSrcGuardEnabled = value;
			}
		}
	}
}
