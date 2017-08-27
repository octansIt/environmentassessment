namespace EnvironmentAssessment.Common.VimApi
{
	public class HostVirtualNicManagerInfo : DynamicData
	{
		protected VirtualNicManagerNetConfig[] _netConfig;
		public VirtualNicManagerNetConfig[] NetConfig
		{
			get
			{
				return this._netConfig;
			}
			set
			{
				this._netConfig = value;
			}
		}
	}
}
