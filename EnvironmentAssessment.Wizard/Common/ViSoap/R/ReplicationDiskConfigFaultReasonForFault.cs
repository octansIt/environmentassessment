namespace EnvironmentAssessment.Common.VISoap
{
    public enum ReplicationDiskConfigFaultReasonForFault
	{
		diskNotFound,
		diskTypeNotSupported,
		invalidDiskKey,
		invalidDiskReplicationId,
		duplicateDiskReplicationId,
		invalidPersistentFilePath,
		reconfigureDiskReplicationIdNotAllowed
	}
}
