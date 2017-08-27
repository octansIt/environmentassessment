namespace EnvironmentAssessment.Common.VimApi
{
	public enum HostCapabilityFtUnsupportedReason
	{
		vMotionNotLicensed,
		missingVMotionNic,
		missingFTLoggingNic,
		ftNotLicensed,
		haAgentIssue,
		unsupportedProduct,
		cpuHvUnsupported,
		cpuHwmmuUnsupported,
		cpuHvDisabled
	}
}
