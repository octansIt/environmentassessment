namespace EnvironmentAssessment.Common.VISoap
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
