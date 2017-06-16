namespace EnvironmentAssessment.Common.VISoap
{
    public class HostRuntimeInfoNetworkRuntimeInfo : DynamicData
	{
		protected HostRuntimeInfoNetStackInstanceRuntimeInfo[] _netStackInstanceRuntimeInfo;
		protected HostNetworkResourceRuntime _networkResourceRuntime;
		public HostRuntimeInfoNetStackInstanceRuntimeInfo[] NetStackInstanceRuntimeInfo
		{
			get
			{
				return this._netStackInstanceRuntimeInfo;
			}
			set
			{
				this._netStackInstanceRuntimeInfo = value;
			}
		}
		public HostNetworkResourceRuntime NetworkResourceRuntime
		{
			get
			{
				return this._networkResourceRuntime;
			}
			set
			{
				this._networkResourceRuntime = value;
			}
		}
	}
}
