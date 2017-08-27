namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanHostRuntimeInfo : DynamicData
	{
		protected VsanHostMembershipInfo[] _membershipList;
		protected VsanHostRuntimeInfoDiskIssue[] _diskIssues;
		protected int? _accessGenNo;
		public VsanHostMembershipInfo[] MembershipList
		{
			get
			{
				return this._membershipList;
			}
			set
			{
				this._membershipList = value;
			}
		}
		public VsanHostRuntimeInfoDiskIssue[] DiskIssues
		{
			get
			{
				return this._diskIssues;
			}
			set
			{
				this._diskIssues = value;
			}
		}
		public int? AccessGenNo
		{
			get
			{
				return this._accessGenNo;
			}
			set
			{
				this._accessGenNo = value;
			}
		}
	}
}
