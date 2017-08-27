namespace EnvironmentAssessment.Common.VimApi
{
	public class DiskNotSupported : VirtualHardwareCompatibilityIssue
	{
		protected int _disk;
		public int Disk
		{
			get
			{
				return this._disk;
			}
			set
			{
				this._disk = value;
			}
		}
	}
}
