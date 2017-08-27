namespace EnvironmentAssessment.Common.VimApi
{
	public class VsanUpgradeSystemMissingHostsInClusterIssue_LinkedView
	{
		protected HostSystem[] _hosts;
		public HostSystem[] Hosts
		{
			get
			{
				return this._hosts;
			}
			set
			{
				this._hosts = value;
			}
		}
	}
}
