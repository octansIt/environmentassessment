namespace EnvironmentAssessment.Common.VISoap
{
    public class VirtualParallelPortFileBackingInfo : VirtualDeviceFileBackingInfo
	{
		public new VirtualParallelPortFileBackingInfo_LinkedView LinkedView
		{
			get
			{
				return (VirtualParallelPortFileBackingInfo_LinkedView)this._linkedView;
			}
		}
	}
}
