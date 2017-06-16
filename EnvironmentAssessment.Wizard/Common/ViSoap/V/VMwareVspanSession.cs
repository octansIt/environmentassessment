namespace EnvironmentAssessment.Common.VISoap
{
    public class VMwareVspanSession : DynamicData
	{
		protected string _key;
		protected string _name;
		protected string _description;
		protected bool _enabled;
		protected VMwareVspanPort _sourcePortTransmitted;
		protected VMwareVspanPort _sourcePortReceived;
		protected VMwareVspanPort _destinationPort;
		protected int? _encapsulationVlanId;
		protected bool _stripOriginalVlan;
		protected int? _mirroredPacketLength;
		protected bool _normalTrafficAllowed;
		protected string _sessionType;
		protected int? _samplingRate;
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		public bool Enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				this._enabled = value;
			}
		}
		public VMwareVspanPort SourcePortTransmitted
		{
			get
			{
				return this._sourcePortTransmitted;
			}
			set
			{
				this._sourcePortTransmitted = value;
			}
		}
		public VMwareVspanPort SourcePortReceived
		{
			get
			{
				return this._sourcePortReceived;
			}
			set
			{
				this._sourcePortReceived = value;
			}
		}
		public VMwareVspanPort DestinationPort
		{
			get
			{
				return this._destinationPort;
			}
			set
			{
				this._destinationPort = value;
			}
		}
		public int? EncapsulationVlanId
		{
			get
			{
				return this._encapsulationVlanId;
			}
			set
			{
				this._encapsulationVlanId = value;
			}
		}
		public bool StripOriginalVlan
		{
			get
			{
				return this._stripOriginalVlan;
			}
			set
			{
				this._stripOriginalVlan = value;
			}
		}
		public int? MirroredPacketLength
		{
			get
			{
				return this._mirroredPacketLength;
			}
			set
			{
				this._mirroredPacketLength = value;
			}
		}
		public bool NormalTrafficAllowed
		{
			get
			{
				return this._normalTrafficAllowed;
			}
			set
			{
				this._normalTrafficAllowed = value;
			}
		}
		public string SessionType
		{
			get
			{
				return this._sessionType;
			}
			set
			{
				this._sessionType = value;
			}
		}
		public int? SamplingRate
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
	}
}
