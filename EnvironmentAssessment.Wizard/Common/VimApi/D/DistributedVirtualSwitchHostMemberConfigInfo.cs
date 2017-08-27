namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchHostMemberConfigInfo : DynamicData
	{
		protected ManagedObjectReference _host;
		protected int _maxProxySwitchPorts;
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _vendorSpecificConfig;
		protected DistributedVirtualSwitchHostMemberBacking _backing;
		protected DistributedVirtualSwitchHostMemberConfigInfo_LinkedView _linkedView;
		public ManagedObjectReference Host
		{
			get
			{
				return this._host;
			}
			set
			{
				this._host = value;
			}
		}
		public int MaxProxySwitchPorts
		{
			get
			{
				return this._maxProxySwitchPorts;
			}
			set
			{
				this._maxProxySwitchPorts = value;
			}
		}
		public DistributedVirtualSwitchKeyedOpaqueBlob[] VendorSpecificConfig
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
		public DistributedVirtualSwitchHostMemberBacking Backing
		{
			get
			{
				return this._backing;
			}
			set
			{
				this._backing = value;
			}
		}
		public DistributedVirtualSwitchHostMemberConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
