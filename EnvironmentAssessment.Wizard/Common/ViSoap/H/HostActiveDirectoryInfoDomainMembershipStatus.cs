namespace EnvironmentAssessment.Common.VISoap
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
