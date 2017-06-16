namespace EnvironmentAssessment.Common.VISoap
{
    public class DvsMacNetworkRuleQualifier : DvsNetworkRuleQualifier
	{
		protected MacAddress _sourceAddress;
		protected MacAddress _destinationAddress;
		protected IntExpression _protocol;
		protected IntExpression _vlanId;
		public MacAddress SourceAddress
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
		public MacAddress DestinationAddress
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
		public IntExpression VlanId
		{
			get
			{
				return this._vlanId;
			}
			set
			{
				this._vlanId = value;
			}
		}
	}
}
