namespace EnvironmentAssessment.Common.VimApi
{
	public class VAppProductInfo : DynamicData
	{
		protected int _key;
		protected string _classId;
		protected string _instanceId;
		protected string _name;
		protected string _vendor;
		protected string _version;
		protected string _fullVersion;
		protected string _vendorUrl;
		protected string _productUrl;
		protected string _appUrl;
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
		public string ClassId
		{
			get
			{
				return this._classId;
			}
			set
			{
				this._classId = value;
			}
		}
		public string InstanceId
		{
			get
			{
				return this._instanceId;
			}
			set
			{
				this._instanceId = value;
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
		public string FullVersion
		{
			get
			{
				return this._fullVersion;
			}
			set
			{
				this._fullVersion = value;
			}
		}
		public string VendorUrl
		{
			get
			{
				return this._vendorUrl;
			}
			set
			{
				this._vendorUrl = value;
			}
		}
		public string ProductUrl
		{
			get
			{
				return this._productUrl;
			}
			set
			{
				this._productUrl = value;
			}
		}
		public string AppUrl
		{
			get
			{
				return this._appUrl;
			}
			set
			{
				this._appUrl = value;
			}
		}
	}
}
