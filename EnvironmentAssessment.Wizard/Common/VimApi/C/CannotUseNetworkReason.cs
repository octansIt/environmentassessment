namespace EnvironmentAssessment.Common.VimApi
{
	public enum CannotUseNetworkReason
	{
		NetworkReservationNotSupported,
		MismatchedNetworkPolicies,
		MismatchedDvsVersionOrVendor,
		VMotionToUnsupportedNetworkType
	}
}
