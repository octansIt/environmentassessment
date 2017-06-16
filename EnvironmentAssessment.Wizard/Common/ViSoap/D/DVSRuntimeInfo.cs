namespace EnvironmentAssessment.Common.VISoap
{
    public class DVSRuntimeInfo : DynamicData
	{
		protected HostMemberRuntimeInfo[] _hostMemberRuntime;
		protected DvsResourceRuntimeInfo _resourceRuntimeInfo;
		public HostMemberRuntimeInfo[] HostMemberRuntime
		{
			get
			{
				return this._hostMemberRuntime;
			}
			set
			{
				this._hostMemberRuntime = value;
			}
		}
		public DvsResourceRuntimeInfo ResourceRuntimeInfo
		{
			get
			{
				return this._resourceRuntimeInfo;
			}
			set
			{
				this._resourceRuntimeInfo = value;
			}
		}
	}
}
