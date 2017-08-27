namespace EnvironmentAssessment.Common.VimApi
{
	public class VmwareDistributedVirtualSwitchTrunkVlanSpec : VmwareDistributedVirtualSwitchVlanSpec
	{
		protected NumericRange[] _vlanId;
		public NumericRange[] VlanId
		{
			get
			{
				return this._vlanId;
			}
			set
			{
				this._vlanId = value;
			}
		}
	}
}
