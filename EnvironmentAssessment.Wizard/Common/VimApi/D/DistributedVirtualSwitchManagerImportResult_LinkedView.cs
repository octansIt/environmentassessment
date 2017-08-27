namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchManagerImportResult_LinkedView
	{
		protected DistributedVirtualSwitch[] _distributedVirtualSwitch;
		protected DistributedVirtualPortgroup[] _distributedVirtualPortgroup;
		public DistributedVirtualSwitch[] DistributedVirtualSwitch
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
		public DistributedVirtualPortgroup[] DistributedVirtualPortgroup
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
	}
}
