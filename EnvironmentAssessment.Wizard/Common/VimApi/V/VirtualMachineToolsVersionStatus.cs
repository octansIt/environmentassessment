namespace EnvironmentAssessment.Common.VimApi
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
