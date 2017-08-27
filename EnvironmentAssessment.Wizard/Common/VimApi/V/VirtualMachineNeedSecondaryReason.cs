namespace EnvironmentAssessment.Common.VimApi
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
