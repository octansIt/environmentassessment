namespace EnvironmentAssessment.Common.VISoap
{
    public class ReplicationVmProgressInfo : DynamicData
	{
		protected int _progress;
		protected long _bytesTransferred;
		protected long _bytesToTransfer;
		protected long? _checksumTotalBytes;
		protected long? _checksumComparedBytes;
		public int Progress
		{
			get
			{
				return this._progress;
			}
			set
			{
				this._progress = value;
			}
		}
		public long BytesTransferred
		{
			get
			{
				return this._bytesTransferred;
			}
			set
			{
				this._bytesTransferred = value;
			}
		}
		public long BytesToTransfer
		{
			get
			{
				return this._bytesToTransfer;
			}
			set
			{
				this._bytesToTransfer = value;
			}
		}
		public long? ChecksumTotalBytes
		{
			get
			{
				return this._checksumTotalBytes;
			}
			set
			{
				this._checksumTotalBytes = value;
			}
		}
		public long? ChecksumComparedBytes
		{
			get
			{
				return this._checksumComparedBytes;
			}
			set
			{
				this._checksumComparedBytes = value;
			}
		}
	}
}
