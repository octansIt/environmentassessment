namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionClientInfo : DynamicData
	{
		protected string _version;
		protected Description _description;
		protected string _company;
		protected string _type;
		protected string _url;
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
		public Description Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public string Company
		{
			get
			{
				return this._company;
			}
			set
			{
				this._company = value;
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
