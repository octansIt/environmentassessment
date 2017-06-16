namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsPortBlockedEvent : DvsEvent
	{
		protected string _portKey;
		protected string _statusDetail;
		protected DVPortStatus _runtimeInfo;
		public string PortKey
		{
			get
			{
				return this._portKey;
			}
			set
			{
				this._portKey = value;
			}
		}
		public string StatusDetail
		{
			get
			{
				return this._statusDetail;
			}
			set
			{
				this._statusDetail = value;
			}
		}
		public DVPortStatus RuntimeInfo
		{
			get
			{
				return this._runtimeInfo;
			}
			set
			{
				this._runtimeInfo = value;
			}
		}
	}
}
