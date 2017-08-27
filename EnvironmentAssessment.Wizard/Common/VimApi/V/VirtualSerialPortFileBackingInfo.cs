namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualSerialPortFileBackingInfo : VirtualDeviceFileBackingInfo
	{
		public new VirtualSerialPortFileBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualSerialPortFileBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
