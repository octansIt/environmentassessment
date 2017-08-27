namespace EnvironmentAssessment.Common.VimApi
{
	public class DistributedVirtualSwitchHostMemberRuntimeState : DynamicData
	{
		protected int _currentMaxProxySwitchPorts;
		public int CurrentMaxProxySwitchPorts
		{
			get
			{
				return this._currentMaxProxySwitchPorts;
			}
			set
			{
				this._currentMaxProxySwitchPorts = value;
			}
		}
	}
}
