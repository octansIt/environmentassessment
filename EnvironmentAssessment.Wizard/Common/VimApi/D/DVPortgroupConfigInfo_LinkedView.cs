namespace EnvironmentAssessment.Common.VimApi
{
	public class DVPortgroupConfigInfo_LinkedView
	{
		protected DistributedVirtualSwitch _distributedVirtualSwitch;
		protected ManagedEntity[] _scope;
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
		public ManagedEntity[] Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
			}
		}
	}
}
