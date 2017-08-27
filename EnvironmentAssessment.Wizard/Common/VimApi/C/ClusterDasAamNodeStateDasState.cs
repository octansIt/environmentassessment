namespace EnvironmentAssessment.Common.VimApi
{
	public enum ClusterDasAamNodeStateDasState
	{
		uninitialized,
		initialized,
		configuring,
		unconfiguring,
		running,
		error,
		agentShutdown,
		nodeFailed
	}
}
