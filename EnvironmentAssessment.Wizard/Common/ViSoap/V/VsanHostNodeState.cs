namespace EnvironmentAssessment.Common.VISoap
{
    public enum VsanHostNodeState
	{
		error,
		disabled,
		agent,
		master,
		backup,
		starting,
		stopping,
		enteringMaintenanceMode,
		exitingMaintenanceMode,
		decommissioning
	}
}
