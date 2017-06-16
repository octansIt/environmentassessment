namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualUSBRemoteClientBackingInfo : VirtualDeviceRemoteDeviceBackingInfo
	{
		protected string _hostname;
		public string Hostname
		{
			get
			{
				return this._hostname;
			}
			set
			{
				this._hostname = value;
			}
		}
	}
}
