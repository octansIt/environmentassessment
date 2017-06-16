namespace EnvironmentAssessment.Common.VISoap
{
    public class ExtensionServerInfo : DynamicData
	{
		protected string _url;
		protected Description _description;
		protected string _company;
		protected string _type;
		protected string[] _adminEmail;
		protected string _serverThumbprint;
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
		public string[] AdminEmail
		{
			get
			{
				return this._adminEmail;
			}
			set
			{
				this._adminEmail = value;
			}
		}
		public string ServerThumbprint
		{
			get
			{
				return this._serverThumbprint;
			}
			set
			{
				this._serverThumbprint = value;
			}
		}
	}
}
