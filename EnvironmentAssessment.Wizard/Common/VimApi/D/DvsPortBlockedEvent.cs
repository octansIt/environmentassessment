namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortBlockedEvent : DvsEvent
	{
		protected string _portKey;
		protected string _statusDetail;
		protected DVPortStatus _runtimeInfo;
		protected string _prevBlockState;
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
		public string PrevBlockState
		{
			get
			{
				return this._prevBlockState;
			}
			set
			{
				this._prevBlockState = value;
			}
		}
	}
}
