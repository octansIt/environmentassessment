namespace EnvironmentAssessment.Common.VimApi
{
	public class VmwareDistributedVirtualSwitchPvlanSpec : VmwareDistributedVirtualSwitchVlanSpec
	{
		protected int _pvlanId;
		public int PvlanId
		{
			get
			{
				return this._pvlanId;
			}
			set
			{
				this._pvlanId = value;
			}
		}
	}
}
