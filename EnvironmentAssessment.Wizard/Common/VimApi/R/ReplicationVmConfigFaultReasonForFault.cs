namespace EnvironmentAssessment.Common.VimApi
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
		replicationConfigurationFailed,
		encryptedVm
	}
}
