namespace EnvironmentAssessment.Common.VISoap
{
    public class DistributedVirtualSwitchHostMemberConfigSpec : DynamicData
	{
		protected string _operation;
		protected ManagedObjectReference _host;
		protected DistributedVirtualSwitchHostMemberBacking _backing;
		protected int? _maxProxySwitchPorts;
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _vendorSpecificConfig;
		protected DistributedVirtualSwitchHostMemberConfigSpec_LinkedView _linkedView;
		public string Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this._operation = value;
			}
		}
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
		public int? MaxProxySwitchPorts
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
		public DistributedVirtualSwitchHostMemberConfigSpec_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
