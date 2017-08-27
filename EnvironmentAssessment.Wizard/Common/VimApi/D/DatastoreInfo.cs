using System;

namespace EnvironmentAssessment.Common.VimApi
{
	public class DatastoreInfo : DynamicData
	{
		protected string _name;
		protected string _url;
		protected long _freeSpace;
		protected long _maxFileSize;
		protected long? _maxVirtualDiskCapacity;
		protected long _maxMemoryFileSize;
		protected DateTime? _timestamp;
		protected string _containerId;
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
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
		public long MaxFileSize
		{
			get
			{
				return this._maxFileSize;
			}
			set
			{
				this._maxFileSize = value;
			}
		}
		public long? MaxVirtualDiskCapacity
		{
			get
			{
				return this._maxVirtualDiskCapacity;
			}
			set
			{
				this._maxVirtualDiskCapacity = value;
			}
		}
		public long MaxMemoryFileSize
		{
			get
			{
				return this._maxMemoryFileSize;
			}
			set
			{
				this._maxMemoryFileSize = value;
			}
		}
		public DateTime? Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		public string ContainerId
		{
			get
			{
				return this._containerId;
			}
			set
			{
				this._containerId = value;
			}
		}
	}
}
