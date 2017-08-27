namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchInfo_LinkedView
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
