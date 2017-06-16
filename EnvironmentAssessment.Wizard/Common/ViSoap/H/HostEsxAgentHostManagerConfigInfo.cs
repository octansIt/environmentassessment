namespace EnvironmentAssessment.Common.VISoap
{
    public class HostEsxAgentHostManagerConfigInfo : DynamicData
	{
		protected ManagedObjectReference _agentVmDatastore;
		protected ManagedObjectReference _agentVmNetwork;
		protected HostEsxAgentHostManagerConfigInfo_LinkedView _linkedView;
		public ManagedObjectReference AgentVmDatastore
		{
			get
			{
				return this._agentVmDatastore;
			}
			set
			{
				this._agentVmDatastore = value;
			}
		}
		public ManagedObjectReference AgentVmNetwork
		{
			get
			{
				return this._agentVmNetwork;
			}
			set
			{
				this._agentVmNetwork = value;
			}
		}
		public HostEsxAgentHostManagerConfigInfo_LinkedView LinkedView
		{
			get
			{
				return this._linkedView;
			}
		}
	}
}
