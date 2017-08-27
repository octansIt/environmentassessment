namespace EnvironmentAssessment.Common.VimApi
{
	public class ShrinkDiskFault : VimFault
	{
		protected int? _diskId;
		public int? DiskId
		{
			get
			{
				return this._diskId;
			}
			set
			{
				this._diskId = value;
			}
		}
	}
}
