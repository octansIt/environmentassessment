namespace EnvironmentAssessment.Common.VISoap
{
    public class OvfFile : DynamicData
	{
		protected string _deviceId;
		protected string _path;
		protected string _compressionMethod;
		protected long? _chunkSize;
		protected long _size;
		protected long? _capacity;
		protected long? _populatedSize;
		public string DeviceId
		{
			get
			{
				return this._deviceId;
			}
			set
			{
				this._deviceId = value;
			}
		}
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this._path = value;
			}
		}
		public string CompressionMethod
		{
			get
			{
				return this._compressionMethod;
			}
			set
			{
				this._compressionMethod = value;
			}
		}
		public long? ChunkSize
		{
			get
			{
				return this._chunkSize;
			}
			set
			{
				this._chunkSize = value;
			}
		}
		public long Size
		{
			get
			{
				return this._size;
			}
			set
			{
				this._size = value;
			}
		}
		public long? Capacity
		{
			get
			{
				return this._capacity;
			}
			set
			{
				this._capacity = value;
			}
		}
		public long? PopulatedSize
		{
			get
			{
				return this._populatedSize;
			}
			set
			{
				this._populatedSize = value;
			}
		}
	}
}
