namespace EnvironmentAssessment.Common.VISoap
{
    public enum ReplicationVmConfigFaultReasonForFault
	{
		incompatibleHwVersion,
		invalidVmReplicationId,
		invalidGenerationNumber,
		outOfBoundsRpoValue,
		invalidDestinationIpAddress,
		invalidDestinationPort,
		invalidExtraVmOptions,
		staleGenerationNumber,
		reconfigureVmReplicationIdNotAllowed,
		cannotRetrieveVmReplicationConfiguration,
		replicationAlreadyEnabled,
		invalidPriorConfiguration,
		replicationNotEnabled,
		replicationConfigurationFailed
	}
}
