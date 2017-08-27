namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualMachineFileLayoutExFileInfo : DynamicData
	{
		protected int _key;
		protected string _name;
		protected string _type;
		protected long _size;
		protected long? _uniqueSize;
		protected string _backingObjectId;
		protected bool? _accessible;
		public int Key
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
		public string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
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
		public long? UniqueSize
		{
			get
			{
				return this._uniqueSize;
			}
			set
			{
				this._uniqueSize = value;
			}
		}
		public string BackingObjectId
		{
			get
			{
				return this._backingObjectId;
			}
			set
			{
				this._backingObjectId = value;
			}
		}
		public bool? Accessible
		{
			get
			{
				return this._accessible;
			}
			set
			{
				this._accessible = value;
			}
		}
	}
}
