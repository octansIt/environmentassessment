namespace EnvironmentAssessment.Common.VISoap
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
