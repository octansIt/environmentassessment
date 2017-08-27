namespace EnvironmentAssessment.Common.VimApi
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
