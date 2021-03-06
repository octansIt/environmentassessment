namespace EnvironmentAssessment.Common.VimApi
{
	public enum ClusterDasFdmAvailabilityState
	{
		uninitialized,
		election,
		master,
		connectedToMaster,
		networkPartitionedFromMaster,
		networkIsolated,
		hostDown,
		initializationError,
		uninitializationError,
		fdmUnreachable
	}
}
