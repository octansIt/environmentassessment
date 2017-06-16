namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtExtendedProductInfo : DynamicData
	{
		protected string _companyUrl;
		protected string _productUrl;
		protected string _managementUrl;
		protected ManagedObjectReference _self;
		protected ExtExtendedProductInfo_LinkedView _linkedView;
		public string CompanyUrl
		{
			get
			{
				return this._companyUrl;
			}
			set
			{
				this._companyUrl = value;
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
		public string ManagementUrl
		{
			get
			{
				return this._managementUrl;
			}
			set
			{
				this._managementUrl = value;
			}
		}
		public ManagedObjectReference Self
		{
			get
			{
				return this._self;
			}
			set
			{
				this._self = value;
			}
		}
		public ExtExtendedProductInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
