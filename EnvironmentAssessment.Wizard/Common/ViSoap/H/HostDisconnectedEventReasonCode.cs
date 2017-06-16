namespace EnvironmentAssessment.Common.VISoap
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
