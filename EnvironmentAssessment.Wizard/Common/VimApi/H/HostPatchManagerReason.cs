namespace EnvironmentAssessment.Common.VimApi
{
	public enum HostPatchManagerReason
	{
		obsoleted,
		missingPatch,
		missingLib,
		hasDependentPatch,
		conflictPatch,
		conflictLib
	}
}
