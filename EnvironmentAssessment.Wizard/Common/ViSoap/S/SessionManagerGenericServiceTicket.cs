namespace EnvironmentAssessment.Common.VISoap
{
    public class SessionManagerGenericServiceTicket : DynamicData
	{
		protected string _id;
		protected string _hostName;
		protected string _sslThumbprint;
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
		public string HostName
		{
			get
			{
				return this._hostName;
			}
			set
			{
				this._hostName = value;
			}
		}
		public string SslThumbprint
		{
			get
			{
				return this._sslThumbprint;
			}
			set
			{
				this._sslThumbprint = value;
			}
		}
	}
}
