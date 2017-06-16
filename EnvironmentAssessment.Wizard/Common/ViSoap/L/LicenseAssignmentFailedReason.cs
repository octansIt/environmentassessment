namespace EnvironmentAssessment.Common.VISoap
{
    public enum LicenseAssignmentFailedReason
	{
		keyEntityMismatch,
		downgradeDisallowed,
		inventoryNotManageableByVirtualCenter,
		hostsUnmanageableByVirtualCenterWithoutLicenseServer
	}
}
