namespace EnvironmentAssessment.Common.VimApi
{
	public class DuplicateIpDetectedEvent : HostEvent
	{
		protected string _duplicateIP;
		protected string _macAddress;
		public string DuplicateIP
		{
			get
			{
				return this._duplicateIP;
			}
			set
			{
				this._duplicateIP = value;
			}
		}
		public string MacAddress
		{
			get
			{
				return this._macAddress;
			}
			set
			{
				this._macAddress = value;
			}
		}
	}
}
