namespace EnvironmentAssessment.Common.VISoap
{
    public class NetworkBandwidthAllocationInfo : ResourceAllocationInfo
	{
		protected ManagedObjectReference _distributedVirtualSwitch;
		protected DistributedVirtualPort _distributedVirtualPort;
		protected HostNetworkTrafficShapingPolicy _inShapingPolicy;
		protected HostNetworkTrafficShapingPolicy _outShapingPolicy;
		protected NetworkBandwidthAllocationInfo_LinkedView _linkedView;
		public ManagedObjectReference DistributedVirtualSwitch
		{
			get
			{
				return this._distributedVirtualSwitch;
			}
			set
			{
				this._distributedVirtualSwitch = value;
			}
		}
		public DistributedVirtualPort DistributedVirtualPort
		{
			get
			{
				return this._distributedVirtualPort;
			}
			set
			{
				this._distributedVirtualPort = value;
			}
		}
		public HostNetworkTrafficShapingPolicy InShapingPolicy
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
		public HostNetworkTrafficShapingPolicy OutShapingPolicy
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
		public NetworkBandwidthAllocationInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
