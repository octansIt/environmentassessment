namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSFeatureCapability : DVSFeatureCapability
	{
		protected bool? _vspanSupported;
		protected bool? _lldpSupported;
		protected bool? _ipfixSupported;
		protected VMwareDvsIpfixCapability _ipfixCapability;
		protected bool? _multicastSnoopingSupported;
		protected VMwareDVSVspanCapability _vspanCapability;
		protected VMwareDvsLacpCapability _lacpCapability;
		public bool? VspanSupported
		{
			get
			{
				return this._vspanSupported;
			}
			set
			{
				this._vspanSupported = value;
			}
		}
		public bool? LldpSupported
		{
			get
			{
				return this._lldpSupported;
			}
			set
			{
				this._lldpSupported = value;
			}
		}
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
		public VMwareDvsIpfixCapability IpfixCapability
		{
			get
			{
				return this._ipfixCapability;
			}
			set
			{
				this._ipfixCapability = value;
			}
		}
		public bool? MulticastSnoopingSupported
		{
			get
			{
				return this._multicastSnoopingSupported;
			}
			set
			{
				this._multicastSnoopingSupported = value;
			}
		}
		public VMwareDVSVspanCapability VspanCapability
		{
			get
			{
				return this._vspanCapability;
			}
			set
			{
				this._vspanCapability = value;
			}
		}
		public VMwareDvsLacpCapability LacpCapability
		{
			get
			{
				return this._lacpCapability;
			}
			set
			{
				this._lacpCapability = value;
			}
		}
	}
}
