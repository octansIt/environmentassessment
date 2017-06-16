namespace EnvironmentAssessment.Common.VISoap
{
    public enum VirtualMachineToolsVersionStatus
	{
		guestToolsNotInstalled,
		guestToolsNeedUpgrade,
		guestToolsCurrent,
		guestToolsUnmanaged,
		guestToolsTooOld,
		guestToolsSupportedOld,
		guestToolsSupportedNew,
		guestToolsTooNew,
		guestToolsBlacklisted
	}
}
