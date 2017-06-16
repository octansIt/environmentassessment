namespace EnvironmentAssessment.Common.VISoap
{
    public class HttpNfcLeaseDeviceUrl : DynamicData
	{
		protected string _key;
		protected string _importKey;
		protected string _url;
		protected string _sslThumbprint;
		protected bool? _disk;
		protected string _targetId;
		protected string _datastoreKey;
		protected long? _fileSize;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string ImportKey
		{
			get
			{
				return this._importKey;
			}
			set
			{
				this._importKey = value;
			}
		}
		public string Url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}
		public string SslThumbprint
		{
			get
			{
				return this._sslThumbprint;
			}
			set
			{
				this._sslThumbprint = value;
			}
		}
		public bool? Disk
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
		public string TargetId
		{
			get
			{
				return this._targetId;
			}
			set
			{
				this._targetId = value;
			}
		}
		public string DatastoreKey
		{
			get
			{
				return this._datastoreKey;
			}
			set
			{
				this._datastoreKey = value;
			}
		}
		public long? FileSize
		{
			get
			{
				return this._fileSize;
			}
			set
			{
				this._fileSize = value;
			}
		}
	}
}
