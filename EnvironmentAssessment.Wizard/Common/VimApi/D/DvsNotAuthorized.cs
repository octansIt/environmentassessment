namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsNotAuthorized : DvsFault
	{
		protected string _sessionExtensionKey;
		protected string _dvsExtensionKey;
		public string SessionExtensionKey
		{
			get
			{
				return this._sessionExtensionKey;
			}
			set
			{
				this._sessionExtensionKey = value;
			}
		}
		public string DvsExtensionKey
		{
			get
			{
				return this._dvsExtensionKey;
			}
			set
			{
				this._dvsExtensionKey = value;
			}
		}
	}
}
