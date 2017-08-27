namespace EnvironmentAssessment.Common.VimApi
{
	public class HostEsxAgentHostManagerConfigInfo_LinkedView
	{
		protected Datastore _agentVmDatastore;
		protected Network _agentVmNetwork;
		public Datastore AgentVmDatastore
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
		public Network AgentVmNetwork
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
	}
}
