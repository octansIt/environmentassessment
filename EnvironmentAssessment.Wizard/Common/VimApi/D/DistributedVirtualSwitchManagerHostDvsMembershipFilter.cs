namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchManagerHostDvsMembershipFilter : DistributedVirtualSwitchManagerHostDvsFilterSpec
	{
		protected ManagedObjectReference _distributedVirtualSwitch;
		protected DistributedVirtualSwitchManagerHostDvsMembershipFilter_LinkedView _linkedView;
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
		public DistributedVirtualSwitchManagerHostDvsMembershipFilter_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
