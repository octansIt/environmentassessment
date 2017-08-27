namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchManagerHostContainerFilter : DistributedVirtualSwitchManagerHostDvsFilterSpec
	{
		protected DistributedVirtualSwitchManagerHostContainer _hostContainer;
		public DistributedVirtualSwitchManagerHostContainer HostContainer
		{
			get
			{
				return this._hostContainer;
			}
			set
			{
				this._hostContainer = value;
			}
		}
	}
}
