namespace EnvironmentAssessment.Common.VISoap
{
    public class AboutInfo : DynamicData
	{
		protected string _name;
		protected string _fullName;
		protected string _vendor;
		protected string _version;
		protected string _build;
		protected string _localeVersion;
		protected string _localeBuild;
		protected string _osType;
		protected string _productLineId;
		protected string _apiType;
		protected string _apiVersion;
		protected string _instanceUuid;
		protected string _licenseProductName;
		protected string _licenseProductVersion;
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
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
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
		public string Build
		{
			get
			{
				return this._build;
			}
			set
			{
				this._build = value;
			}
		}
		public string LocaleVersion
		{
			get
			{
				return this._localeVersion;
			}
			set
			{
				this._localeVersion = value;
			}
		}
		public string LocaleBuild
		{
			get
			{
				return this._localeBuild;
			}
			set
			{
				this._localeBuild = value;
			}
		}
		public string OsType
		{
			get
			{
				return this._osType;
			}
			set
			{
				this._osType = value;
			}
		}
		public string ProductLineId
		{
			get
			{
				return this._productLineId;
			}
			set
			{
				this._productLineId = value;
			}
		}
		public string ApiType
		{
			get
			{
				return this._apiType;
			}
			set
			{
				this._apiType = value;
			}
		}
		public string ApiVersion
		{
			get
			{
				return this._apiVersion;
			}
			set
			{
				this._apiVersion = value;
			}
		}
		public string InstanceUuid
		{
			get
			{
				return this._instanceUuid;
			}
			set
			{
				this._instanceUuid = value;
			}
		}
		public string LicenseProductName
		{
			get
			{
				return this._licenseProductName;
			}
			set
			{
				this._licenseProductName = value;
			}
		}
		public string LicenseProductVersion
		{
			get
			{
				return this._licenseProductVersion;
			}
			set
			{
				this._licenseProductVersion = value;
			}
		}
	}
}
