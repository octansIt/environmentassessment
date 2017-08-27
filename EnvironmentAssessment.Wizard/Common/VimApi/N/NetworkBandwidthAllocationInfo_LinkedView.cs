namespace EnvironmentAssessment.Common.VimApi
{
    public class NetworkBandwidthAllocationInfo_LinkedView
	{
		protected DistributedVirtualSwitch _distributedVirtualSwitch;
		public DistributedVirtualSwitch DistributedVirtualSwitch
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
	}
}
