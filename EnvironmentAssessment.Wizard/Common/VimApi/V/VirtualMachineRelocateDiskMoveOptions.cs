namespace EnvironmentAssessment.Common.VimApi
{
	public enum VirtualMachineRelocateDiskMoveOptions
	{
		moveAllDiskBackingsAndAllowSharing,
		moveAllDiskBackingsAndDisallowSharing,
		moveChildMostDiskBacking,
		createNewChildDiskBacking,
		moveAllDiskBackingsAndConsolidate
	}
}
