namespace EnvironmentAssessment.Common.VimApi
{
	public enum HostDasErrorEventHostDasErrorReason
	{
		configFailed,
		timeout,
		communicationInitFailed,
		healthCheckScriptFailed,
		agentFailed,
		agentShutdown,
		isolationAddressUnpingable,
		other
	}
}
