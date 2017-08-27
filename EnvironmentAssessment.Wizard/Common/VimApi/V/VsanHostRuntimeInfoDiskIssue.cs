namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostRuntimeInfoDiskIssue : DynamicData
	{
		protected string _diskId;
		protected string _issue;
		public string DiskId
		{
			get
			{
				return this._diskId;
			}
			set
			{
				this._diskId = value;
			}
		}
		public string Issue
		{
			get
			{
				return this._issue;
			}
			set
			{
				this._issue = value;
			}
		}
	}
}
