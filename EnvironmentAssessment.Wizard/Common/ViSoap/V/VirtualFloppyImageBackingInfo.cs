namespace EnvironmentAssessment.Common.VISoap
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
