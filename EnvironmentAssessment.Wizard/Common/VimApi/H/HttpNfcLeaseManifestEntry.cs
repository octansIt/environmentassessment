namespace EnvironmentAssessment.Common.VimApi
{
	public class HttpNfcLeaseManifestEntry : DynamicData
	{
		protected string _key;
		protected string _sha1;
		protected long _size;
		protected bool _disk;
		protected long? _capacity;
		protected long? _populatedSize;
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
		public string Sha1
		{
			get
			{
				return this._sha1;
			}
			set
			{
				this._sha1 = value;
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
		public bool Disk
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
