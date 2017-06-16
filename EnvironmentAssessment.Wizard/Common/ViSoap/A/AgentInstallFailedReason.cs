namespace EnvironmentAssessment.Common.VISoap
{
    public enum AgentInstallFailedReason
	{
		NotEnoughSpaceOnDevice,
		PrepareToUpgradeFailed,
		AgentNotRunning,
		AgentNotReachable,
		InstallTimedout,
		SignatureVerificationFailed,
		AgentUploadFailed,
		AgentUploadTimedout,
		UnknownInstallerError
	}
}
