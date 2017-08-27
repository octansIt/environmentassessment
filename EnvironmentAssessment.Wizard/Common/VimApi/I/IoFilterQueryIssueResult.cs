namespace EnvironmentAssessment.Common.VimApi
{
	public class IoFilterQueryIssueResult : DynamicData
	{
		protected string _opType;
		protected IoFilterHostIssue[] _hostIssue;
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
		public IoFilterHostIssue[] HostIssue
		{
			get
			{
				return this._hostIssue;
			}
			set
			{
				this._hostIssue = value;
			}
		}
	}
}
