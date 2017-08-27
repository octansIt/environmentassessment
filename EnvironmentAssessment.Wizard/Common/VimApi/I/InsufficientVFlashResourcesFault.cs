namespace EnvironmentAssessment.Common.VimApi
{
	public class InsufficientVFlashResourcesFault : InsufficientResourcesFault
	{
		protected long? _freeSpaceInMB;
		protected long _freeSpace;
		protected long? _requestedSpaceInMB;
		protected long _requestedSpace;
		public long? FreeSpaceInMB
		{
			get
			{
				return this._freeSpaceInMB;
			}
			set
			{
				this._freeSpaceInMB = value;
			}
		}
		public long FreeSpace
		{
			get
			{
				return this._freeSpace;
			}
			set
			{
				this._freeSpace = value;
			}
		}
		public long? RequestedSpaceInMB
		{
			get
			{
				return this._requestedSpaceInMB;
			}
			set
			{
				this._requestedSpaceInMB = value;
			}
		}
		public long RequestedSpace
		{
			get
			{
				return this._requestedSpace;
			}
			set
			{
				this._requestedSpace = value;
			}
		}
	}
}
