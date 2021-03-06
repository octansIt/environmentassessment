namespace EnvironmentAssessment.Common.VimApi
{
	public class DvsIpNetworkRuleQualifier : DvsNetworkRuleQualifier
	{
		protected IpAddress _sourceAddress;
		protected IpAddress _destinationAddress;
		protected IntExpression _protocol;
		protected DvsIpPort _sourceIpPort;
		protected DvsIpPort _destinationIpPort;
		protected IntExpression _tcpFlags;
		public IpAddress SourceAddress
		{
			get
			{
				return this._sourceAddress;
			}
			set
			{
				this._sourceAddress = value;
			}
		}
		public IpAddress DestinationAddress
		{
			get
			{
				return this._destinationAddress;
			}
			set
			{
				this._destinationAddress = value;
			}
		}
		public IntExpression Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}
		public DvsIpPort SourceIpPort
		{
			get
			{
				return this._sourceIpPort;
			}
			set
			{
				this._sourceIpPort = value;
			}
		}
		public DvsIpPort DestinationIpPort
		{
			get
			{
				return this._destinationIpPort;
			}
			set
			{
				this._destinationIpPort = value;
			}
		}
		public IntExpression TcpFlags
		{
			get
			{
				return this._tcpFlags;
			}
			set
			{
				this._tcpFlags = value;
			}
		}
	}
}
