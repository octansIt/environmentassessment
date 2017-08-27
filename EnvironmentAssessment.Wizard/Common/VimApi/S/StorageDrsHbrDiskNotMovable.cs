namespace EnvironmentAssessment.Common.VimApi
{
	public class StorageDrsHbrDiskNotMovable : VimFault
	{
		protected string _nonMovableDiskIds;
		public string NonMovableDiskIds
		{
			get
			{
				return this._nonMovableDiskIds;
			}
			set
			{
				this._nonMovableDiskIds = value;
			}
		}
	}
}
