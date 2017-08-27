namespace EnvironmentAssessment.Common.VimApi
{
	public class VirtualDiskAntiAffinityRuleSpec : ClusterRuleInfo
	{
		protected int[] _diskId;
		public int[] DiskId
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
	}
}
