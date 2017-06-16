namespace EnvironmentAssessment.Common.VISoap
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
