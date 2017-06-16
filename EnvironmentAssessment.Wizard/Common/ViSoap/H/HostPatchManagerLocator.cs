namespace EnvironmentAssessment.Common.VISoap
{
    public class HostPatchManagerLocator : DynamicData
	{
		protected string _url;
		protected string _proxy;
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
		public string Proxy
		{
			get
			{
				return this._proxy;
			}
			set
			{
				this._proxy = value;
			}
		}
	}
}
