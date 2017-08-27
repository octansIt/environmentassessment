namespace EnvironmentAssessment.Common.VimApi
{
	public class ClusterIoFilterInfo : IoFilterInfo
	{
		protected string _opType;
		protected string _vibUrl;
		public string OpType
		{
			get
			{
				return this._opType;
			}
			set
			{
				this._opType = value;
			}
		}
		public string VibUrl
		{
			get
			{
				return this._vibUrl;
			}
			set
			{
				this._vibUrl = value;
			}
		}
	}
}
