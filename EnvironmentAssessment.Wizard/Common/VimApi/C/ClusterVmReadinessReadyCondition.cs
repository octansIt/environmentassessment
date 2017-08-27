namespace EnvironmentAssessment.Common.VimApi
{
	public enum ClusterVmReadinessReadyCondition
	{
		none,
		poweredOn,
		guestHbStatusGreen,
		appHbStatusGreen,
		useClusterDefault
	}
}
