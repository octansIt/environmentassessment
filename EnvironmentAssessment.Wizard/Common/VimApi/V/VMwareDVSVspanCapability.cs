namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareDVSVspanCapability : DynamicData
	{
		protected bool _mixedDestSupported;
		protected bool _dvportSupported;
		protected bool _remoteSourceSupported;
		protected bool _remoteDestSupported;
		protected bool _encapRemoteSourceSupported;
		protected bool? _erspanProtocolSupported;
		public bool MixedDestSupported
		{
			get
			{
				return this._mixedDestSupported;
			}
			set
			{
				this._mixedDestSupported = value;
			}
		}
		public bool DvportSupported
		{
			get
			{
				return this._dvportSupported;
			}
			set
			{
				this._dvportSupported = value;
			}
		}
		public bool RemoteSourceSupported
		{
			get
			{
				return this._remoteSourceSupported;
			}
			set
			{
				this._remoteSourceSupported = value;
			}
		}
		public bool RemoteDestSupported
		{
			get
			{
				return this._remoteDestSupported;
			}
			set
			{
				this._remoteDestSupported = value;
			}
		}
		public bool EncapRemoteSourceSupported
		{
			get
			{
				return this._encapRemoteSourceSupported;
			}
			set
			{
				this._encapRemoteSourceSupported = value;
			}
		}
		public bool? ErspanProtocolSupported
		{
			get
			{
				return this._erspanProtocolSupported;
			}
			set
			{
				this._erspanProtocolSupported = value;
			}
		}
	}
}
