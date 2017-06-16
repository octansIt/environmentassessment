namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSManagerDvsConfigTarget : DynamicData
	{
		protected DistributedVirtualPortgroupInfo[] _distributedVirtualPortgroup;
		protected DistributedVirtualSwitchInfo[] _distributedVirtualSwitch;
		public DistributedVirtualPortgroupInfo[] DistributedVirtualPortgroup
		{
			get
			{
				return this._distributedVirtualPortgroup;
			}
			set
			{
				this._distributedVirtualPortgroup = value;
			}
		}
		public DistributedVirtualSwitchInfo[] DistributedVirtualSwitch
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
