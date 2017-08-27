namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostConfigInfoNetworkInfoPortConfig : DynamicData
	{
		protected VsanHostIpConfig _ipConfig;
		protected string _device;
		public VsanHostIpConfig IpConfig
		{
			get
			{
				return this._ipConfig;
			}
			set
			{
				this._ipConfig = value;
			}
		}
		public string Device
		{
			get
			{
				return this._device;
			}
			set
			{
				this._device = value;
			}
		}
	}
}
