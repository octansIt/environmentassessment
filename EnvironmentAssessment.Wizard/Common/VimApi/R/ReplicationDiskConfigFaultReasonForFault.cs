namespace EnvironmentAssessment.Common.VimApi
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
