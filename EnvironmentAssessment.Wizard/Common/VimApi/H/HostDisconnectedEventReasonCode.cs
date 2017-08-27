namespace EnvironmentAssessment.Common.VimApi
{
	public enum HostDisconnectedEventReasonCode
	{
		sslThumbprintVerifyFailed,
		licenseExpired,
		agentUpgrade,
		userRequest,
		insufficientLicenses,
		agentOutOfDate,
		passwordDecryptFailure,
		unknown,
		vcVRAMCapacityExceeded
	}
}
