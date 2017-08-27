namespace EnvironmentAssessment.Common.VimApi
{
	public class OvfFileItem : DynamicData
	{
		protected string _deviceId;
		protected string _path;
		protected string _compressionMethod;
		protected long? _chunkSize;
		protected long? _size;
		protected int _cimType;
		protected bool _create;
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
		public long? Size
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
		public int CimType
		{
			get
			{
				return this._cimType;
			}
			set
			{
				this._cimType = value;
			}
		}
		public bool Create
		{
			get
			{
				return this._create;
			}
			set
			{
				this._create = value;
			}
		}
	}
}
