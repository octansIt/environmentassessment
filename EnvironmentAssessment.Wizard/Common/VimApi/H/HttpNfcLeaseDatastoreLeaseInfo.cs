namespace EnvironmentAssessment.Common.VimApi
{
	public class HttpNfcLeaseDatastoreLeaseInfo : DynamicData
	{
		protected string _datastoreKey;
		protected HttpNfcLeaseHostInfo[] _hosts;
		public string DatastoreKey
		{
			get
			{
				return this._datastoreKey;
			}
			set
			{
				this._datastoreKey = value;
			}
		}
		public HttpNfcLeaseHostInfo[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
	}
}
