namespace EnvironmentAssessment.Common.VimApi
{
	public class HbrManagerReplicationVmInfo : DynamicData
	{
		protected string _state;
		protected ReplicationVmProgressInfo _progressInfo;
		protected string _imageId;
		protected LocalizedMethodFault _lastError;
		public string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public ReplicationVmProgressInfo ProgressInfo
		{
			get
			{
				return this._progressInfo;
			}
			set
			{
				this._progressInfo = value;
			}
		}
		public string ImageId
		{
			get
			{
				return this._imageId;
			}
			set
			{
				this._imageId = value;
			}
		}
		public LocalizedMethodFault LastError
		{
			get
			{
				return this._lastError;
			}
			set
			{
				this._lastError = value;
			}
		}
	}
}
