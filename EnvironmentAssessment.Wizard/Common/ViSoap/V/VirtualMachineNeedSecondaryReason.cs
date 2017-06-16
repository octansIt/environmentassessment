namespace EnvironmentAssessment.Common.VISoap
{
    public enum VirtualMachineNeedSecondaryReason
	{
		initializing,
		divergence,
		lostConnection,
		partialHardwareFailure,
		userAction,
		checkpointError,
		other
	}
}
