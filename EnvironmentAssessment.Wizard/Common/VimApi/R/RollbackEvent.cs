namespace EnvironmentAssessment.Common.VimApi
{
	public class RollbackEvent : DvsEvent
	{
		protected string _hostName;
		protected string _methodName;
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
		public string MethodName
		{
			get
			{
				return this._methodName;
			}
			set
			{
				this._methodName = value;
			}
		}
	}
}
