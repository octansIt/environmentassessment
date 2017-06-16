namespace EnvironmentAssessment.Common.VISoap
{
    public class DVPortState : DynamicData
	{
		protected DVPortStatus _runtimeInfo;
		protected DistributedVirtualSwitchPortStatistics _stats;
		protected DistributedVirtualSwitchKeyedOpaqueBlob[] _vendorSpecificState;
		public DVPortStatus RuntimeInfo
		{
			get
			{
				return this._runtimeInfo;
			}
			set
			{
				this._runtimeInfo = value;
			}
		}
		public DistributedVirtualSwitchPortStatistics Stats
		{
			get
			{
				return this._stats;
			}
			set
			{
				this._stats = value;
			}
		}
		public DistributedVirtualSwitchKeyedOpaqueBlob[] VendorSpecificState
		{
			get
			{
				return this._vendorSpecificState;
			}
			set
			{
				this._vendorSpecificState = value;
			}
		}
	}
}
