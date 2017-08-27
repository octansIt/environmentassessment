namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualFloppyImageBackingInfo : VirtualDeviceFileBackingInfo
	{
		public new VirtualFloppyImageBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualFloppyImageBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
