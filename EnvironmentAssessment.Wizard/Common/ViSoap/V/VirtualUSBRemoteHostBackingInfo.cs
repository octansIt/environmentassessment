namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualUSBRemoteHostBackingInfo : VirtualDeviceDeviceBackingInfo
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
