namespace EnvironmentAssessment.Common.VimApi
{
	public class HostSriovNetworkDevicePoolInfo : HostSriovDevicePoolInfo
	{
		protected string _switchKey;
		protected string _switchUuid;
		protected PhysicalNic[] _pnic;
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
		public PhysicalNic[] Pnic
		{
			get
			{
				return this._pnic;
			}
			set
			{
				this._pnic = value;
			}
		}
	}
}
