namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsPortRuntimeChangeEvent : DvsEvent
	{
		protected string _portKey;
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
