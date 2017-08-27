namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSHealthCheckCapability : DVSHealthCheckCapability
	{
		protected bool _vlanMtuSupported;
		protected bool _teamingSupported;
		public bool VlanMtuSupported
		{
			get
			{
				return this._vlanMtuSupported;
			}
			set
			{
				this._vlanMtuSupported = value;
			}
		}
		public bool TeamingSupported
		{
			get
			{
				return this._teamingSupported;
			}
			set
			{
				this._teamingSupported = value;
			}
		}
	}
}
