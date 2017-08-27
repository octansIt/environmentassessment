namespace EnvironmentAssessment.Common.VimApi
{
	public class NotSupportedHostInDvs : NotSupportedHost
	{
		protected DistributedVirtualSwitchProductSpec _switchProductSpec;
		public DistributedVirtualSwitchProductSpec SwitchProductSpec
		{
			get
			{
				return this._switchProductSpec;
			}
			set
			{
				this._switchProductSpec = value;
			}
		}
	}
}
