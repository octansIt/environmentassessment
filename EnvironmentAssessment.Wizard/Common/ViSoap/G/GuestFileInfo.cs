namespace EnvironmentAssessment.Common.VISoap
{
    public class GuestFileInfo : DynamicData
	{
		protected string _path;
		protected string _type;
		protected long _size;
		protected GuestFileAttributes _attributes;
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
		public GuestFileAttributes Attributes
		{
			get
			{
				return this._attributes;
			}
			set
			{
				this._attributes = value;
			}
		}
	}
}
