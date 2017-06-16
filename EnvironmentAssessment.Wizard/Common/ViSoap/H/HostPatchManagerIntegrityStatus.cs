namespace EnvironmentAssessment.Common.VISoap
{
    public enum HostPatchManagerIntegrityStatus
	{
		validated,
		keyNotFound,
		keyRevoked,
		keyExpired,
		digestMismatch,
		notEnoughSignatures,
		validationError
	}
}
