namespace EnvironmentAssessment.Common.VimApi
{
	public class HostProxySwitchSpec : DynamicData
	{
		protected DistributedVirtualSwitchHostMemberBacking _backing;
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
	}
}
