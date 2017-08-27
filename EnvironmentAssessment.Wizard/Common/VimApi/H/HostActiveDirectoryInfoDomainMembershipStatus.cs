namespace EnvironmentAssessment.Common.VimApi
{
	public enum HostActiveDirectoryInfoDomainMembershipStatus
	{
		unknown,
		ok,
		noServers,
		clientTrustBroken,
		serverTrustBroken,
		inconsistentTrust,
		otherProblem
	}
}
