namespace EnvironmentAssessment.Common.VISoap
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
