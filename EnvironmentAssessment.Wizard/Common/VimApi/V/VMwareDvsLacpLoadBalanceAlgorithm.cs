namespace EnvironmentAssessment.Common.VimApi
{
	public enum VMwareDvsLacpLoadBalanceAlgorithm
	{
		srcMac,
		destMac,
		srcDestMac,
		destIpVlan,
		srcIpVlan,
		srcDestIpVlan,
		destTcpUdpPort,
		srcTcpUdpPort,
		srcDestTcpUdpPort,
		destIpTcpUdpPort,
		srcIpTcpUdpPort,
		srcDestIpTcpUdpPort,
		destIpTcpUdpPortVlan,
		srcIpTcpUdpPortVlan,
		srcDestIpTcpUdpPortVlan,
		destIp,
		srcIp,
		srcDestIp,
		vlan,
		srcPortId
	}
}
