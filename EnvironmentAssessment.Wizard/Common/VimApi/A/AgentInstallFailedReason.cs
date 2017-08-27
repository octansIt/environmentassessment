namespace EnvironmentAssessment.Common.VimApi
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
