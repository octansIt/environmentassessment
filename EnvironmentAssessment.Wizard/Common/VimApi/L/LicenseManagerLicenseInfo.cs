namespace EnvironmentAssessment.Common.VimApi
{
	public class LicenseManagerLicenseInfo : DynamicData
	{
		protected string _licenseKey;
		protected string _editionKey;
		protected string _name;
		protected int _total;
		protected int? _used;
		protected string _costUnit;
		protected KeyAnyValue[] _properties;
		protected KeyValue[] _labels;
		public string LicenseKey
		{
			get
			{
				return this._licenseKey;
			}
			set
			{
				this._licenseKey = value;
			}
		}
		public string EditionKey
		{
			get
			{
				return this._editionKey;
			}
			set
			{
				this._editionKey = value;
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
		public int Total
		{
			get
			{
				return this._total;
			}
			set
			{
				this._total = value;
			}
		}
		public int? Used
		{
			get
			{
				return this._used;
			}
			set
			{
				this._used = value;
			}
		}
		public string CostUnit
		{
			get
			{
				return this._costUnit;
			}
			set
			{
				this._costUnit = value;
			}
		}
		public KeyAnyValue[] Properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				this._properties = value;
			}
		}
		public KeyValue[] Labels
		{
			get
			{
				return this._labels;
			}
			set
			{
				this._labels = value;
			}
		}
	}
}
