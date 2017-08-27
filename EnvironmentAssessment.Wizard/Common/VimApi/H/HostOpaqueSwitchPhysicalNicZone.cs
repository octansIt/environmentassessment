namespace EnvironmentAssessment.Common.VimApi
{
	public class HostOpaqueSwitchPhysicalNicZone : DynamicData
	{
		protected string _key;
		protected string[] _pnicDevice;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string[] PnicDevice
		{
			get
			{
				return this._pnicDevice;
			}
			set
			{
				this._pnicDevice = value;
			}
		}
	}
}
