namespace EnvironmentAssessment.Common.VimApi
{
	public class FilterInUse : ResourceInUse
	{
		protected VirtualDiskId[] _disk;
		public VirtualDiskId[] Disk
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
