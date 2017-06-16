using System;
namespace EnvironmentAssessment.Common.VISoap
{
	public class LocalizationManagerMessageCatalog : DynamicData
	{
		protected string _moduleName;
		protected string _catalogName;
		protected string _locale;
		protected string _catalogUri;
		protected DateTime? _lastModified;
		protected string _md5sum;
		protected string _version;
		public string ModuleName
		{
			get
			{
				return this._moduleName;
			}
			set
			{
				this._moduleName = value;
			}
		}
		public string CatalogName
		{
			get
			{
				return this._catalogName;
			}
			set
			{
				this._catalogName = value;
			}
		}
		public string Locale
		{
			get
			{
				return this._locale;
			}
			set
			{
				this._locale = value;
			}
		}
		public string CatalogUri
		{
			get
			{
				return this._catalogUri;
			}
			set
			{
				this._catalogUri = value;
			}
		}
		public DateTime? LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				this._lastModified = value;
			}
		}
		public string Md5sum
		{
			get
			{
				return this._md5sum;
			}
			set
			{
				this._md5sum = value;
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
	}
}
