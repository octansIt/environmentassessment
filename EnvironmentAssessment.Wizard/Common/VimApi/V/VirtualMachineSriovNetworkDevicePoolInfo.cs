namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineSriovNetworkDevicePoolInfo : VirtualMachineSriovDevicePoolInfo
	{
		protected string _switchKey;
		protected string _switchUuid;
		public string SwitchKey
		{
			get
			{
				return this._switchKey;
			}
			set
			{
				this._switchKey = value;
			}
		}
		public string SwitchUuid
		{
			get
			{
				return this._switchUuid;
			}
			set
			{
				this._switchUuid = value;
			}
		}
	}
}
