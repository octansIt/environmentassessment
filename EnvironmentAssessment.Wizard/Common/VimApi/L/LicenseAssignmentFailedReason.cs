namespace EnvironmentAssessment.Common.VimApi
{
	public enum LicenseAssignmentFailedReason
	{
		keyEntityMismatch,
		downgradeDisallowed,
		inventoryNotManageableByVirtualCenter,
		hostsUnmanageableByVirtualCenterWithoutLicenseServer
	}
}
