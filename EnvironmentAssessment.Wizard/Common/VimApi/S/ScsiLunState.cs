namespace EnvironmentAssessment.Common.VimApi
{
	public enum ScsiLunState
	{
		unknownState,
		ok,
		error,
		off,
		quiesced,
		degraded,
		lostCommunication,
		timeout
	}
}
