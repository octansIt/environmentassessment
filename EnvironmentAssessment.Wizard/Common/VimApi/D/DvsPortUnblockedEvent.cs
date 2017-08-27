namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortUnblockedEvent : DvsEvent
	{
		protected string _portKey;
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
