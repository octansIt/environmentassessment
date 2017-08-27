namespace EnvironmentAssessment.Common.VimApi
{
	public class IoFilterInfo : DynamicData
	{
		protected string _id;
		protected string _name;
		protected string _vendor;
		protected string _version;
		protected string _type;
		protected string _summary;
		protected string _releaseDate;
		public string Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
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
		public string Vendor
		{
			get
			{
				return this._vendor;
			}
			set
			{
				this._vendor = value;
			}
		}
		public string Version
		{
			get
			{
				return this._version;
			}
			set
			{
				this._version = value;
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
		public string Summary
		{
			get
			{
				return this._summary;
			}
			set
			{
				this._summary = value;
			}
		}
		public string ReleaseDate
		{
			get
			{
				return this._releaseDate;
			}
			set
			{
				this._releaseDate = value;
			}
		}
	}
}
