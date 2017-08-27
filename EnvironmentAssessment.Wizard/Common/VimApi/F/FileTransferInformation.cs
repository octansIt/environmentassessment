namespace EnvironmentAssessment.Common.VimApi
{
	public class FileTransferInformation : DynamicData
	{
		protected GuestFileAttributes _attributes;
		protected long _size;
		protected string _url;
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
	}
}
