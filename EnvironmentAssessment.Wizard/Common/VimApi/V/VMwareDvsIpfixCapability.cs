namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDvsIpfixCapability : DynamicData
	{
		protected bool? _ipfixSupported;
		protected bool? _ipv6ForIpfixSupported;
		protected bool? _observationDomainIdSupported;
		public bool? IpfixSupported
		{
			get
			{
				return this._ipfixSupported;
			}
			set
			{
				this._ipfixSupported = value;
			}
		}
		public bool? Ipv6ForIpfixSupported
		{
			get
			{
				return this._ipv6ForIpfixSupported;
			}
			set
			{
				this._ipv6ForIpfixSupported = value;
			}
		}
		public bool? ObservationDomainIdSupported
		{
			get
			{
				return this._observationDomainIdSupported;
			}
			set
			{
				this._observationDomainIdSupported = value;
			}
		}
	}
}
