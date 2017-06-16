namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualCdromIsoBackingInfo : VirtualDeviceFileBackingInfo
	{
		public new VirtualCdromIsoBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualCdromIsoBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
