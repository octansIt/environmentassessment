namespace EnvironmentAssessment.Common.VimApi
{
	public class VMwareIpfixConfig : DynamicData
	{
		protected string _collectorIpAddress;
		protected int? _collectorPort;
		protected long? _observationDomainId;
		protected int _activeFlowTimeout;
		protected int _idleFlowTimeout;
		protected int _samplingRate;
		protected bool _internalFlowsOnly;
		public string CollectorIpAddress
		{
			get
			{
				return this._collectorIpAddress;
			}
			set
			{
				this._collectorIpAddress = value;
			}
		}
		public int? CollectorPort
		{
			get
			{
				return this._collectorPort;
			}
			set
			{
				this._collectorPort = value;
			}
		}
		public long? ObservationDomainId
		{
			get
			{
				return this._observationDomainId;
			}
			set
			{
				this._observationDomainId = value;
			}
		}
		public int ActiveFlowTimeout
		{
			get
			{
				return this._activeFlowTimeout;
			}
			set
			{
				this._activeFlowTimeout = value;
			}
		}
		public int IdleFlowTimeout
		{
			get
			{
				return this._idleFlowTimeout;
			}
			set
			{
				this._idleFlowTimeout = value;
			}
		}
		public int SamplingRate
		{
			get
			{
				return this._samplingRate;
			}
			set
			{
				this._samplingRate = value;
			}
		}
		public bool InternalFlowsOnly
		{
			get
			{
				return this._internalFlowsOnly;
			}
			set
			{
				this._internalFlowsOnly = value;
			}
		}
	}
}
